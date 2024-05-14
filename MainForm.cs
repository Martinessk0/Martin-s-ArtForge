using FinalProject.Modules;
using FinalProject.UndoFeature;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private readonly List<Figure> _figures = new List<Figure>();
        private readonly UndoRedoManager _manager = new UndoRedoManager();
        private DrawingMode _currentDrawingMode = DrawingMode.None;

        private static Color _currColor = Color.Black;

        private Pen _drawingPen = new Pen(_currColor, 5);
        private Brush? _fillingBrush;

        private Point _startPoint, _endPoint;
        private Point _lastMousePos;

        private Figure? _selectedFigure = null;
        private Button lastSelectedButton;

        private bool _isMovable = false;
        private bool _isReadyForFilling = false;

        private double _dpiX, _dpiY;
        private int _x, _y;

        public MainForm()
            => InitializeComponent();

        //Paint Event
        private void mainLayout_Paint(object sender, PaintEventArgs e)
        {
            //Dots per inch
            _dpiX = e.Graphics.DpiX;
            _dpiY = e.Graphics.DpiY;

            foreach (Figure f in _figures)
            {
                _drawingPen.Color = f.OutlineColor;
                if (f.IsFill)
                {
                    _fillingBrush = new SolidBrush(f.FillColor);
                    f.Fill(e.Graphics, _fillingBrush);
                }
                f.Draw(e.Graphics, _drawingPen);
            }
        }


        //Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblCurrColor.BackColor = _currColor;
            pickColor.FlatAppearance.MouseOverBackColor = pickColor.BackColor;
            pickColor.FlatAppearance.MouseDownBackColor = pickColor.BackColor;
            //Preventing lagging when moving the figures
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            mainLayout, new object[] { true });
            var sizeA = mainLayout.Size.Width;
            var sizeB = mainLayout.Size.Height;
            lblSize.Text = $"{sizeA} : {sizeB}";
        }



        //Buttons
        private void btnRectangular_Click(object sender, EventArgs e)
        {
            SelectButton(btnRectangular);
            _isReadyForFilling = false;
            _isMovable = false;
            _currentDrawingMode = DrawingMode.Rectangle;
        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            SelectButton(btnEllipse);
            _isReadyForFilling = false;
            _isMovable = false;
            _currentDrawingMode = DrawingMode.Ellipse;
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            SelectButton(btnSquare);
            _isMovable = false;
            _isReadyForFilling = false;
            _currentDrawingMode = DrawingMode.Square;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            SelectButton(btnLine);
            _isMovable = false;
            _isReadyForFilling = false;
            _currentDrawingMode = DrawingMode.Line;
        }
        private void btnEraser_Click(object sender, EventArgs e)
        {
            SelectButton(btnEraser);
            _isMovable = false;
            _isReadyForFilling = false;
            _currentDrawingMode = DrawingMode.Eraser;
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            SelectButton(btnMove);
            _isMovable = false;
            _isReadyForFilling = false;
            _currentDrawingMode = DrawingMode.Move;
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            SelectButton(btnFill);
            _isReadyForFilling = true;
            _isMovable = false;
            _currentDrawingMode = DrawingMode.Fill;
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manager.Undo();
            mainLayout.Invalidate();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manager.Redo();
            mainLayout.Invalidate();
        }
        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentationForm documentation = new DocumentationForm();
            documentation.ShowDialog();
        }
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm(_manager.HistoryTextBox);
            history.ShowDialog();
        }
        private void calculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculationForm calculation = new CalculationForm(_figures);
            calculation.ShowDialog();
        }
        private void AddFigure(Figure figure)
        {
            ICommand draw = new DrawCommand(_figures, figure);
            _manager.ExecuteCommand(draw);
        }
        private void RemoveFigure(Figure figure)
        {
            ICommand erase = new EraseCommand(_figures, figure);
            _manager.ExecuteCommand(erase);
        }
        private void pickColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _currColor = colorDialog.Color;
                _drawingPen.Color = _currColor;
                lblCurrColor.BackColor = _currColor;
            }
        }



        //Events
        private void MainForm_Resize(object sender, EventArgs e)
        {
            var sizeA = mainLayout.Size.Width;
            var sizeB = mainLayout.Size.Height;
            lblSize.Text = $"{sizeA} : {sizeB}";
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Control)
            {
                _manager.Undo();
                mainLayout.Invalidate();
            }
            if (e.KeyCode == Keys.X && e.Control)
            {
                _manager.Redo();
                mainLayout.Invalidate();
            }
            if (e.KeyCode == Keys.H && e.Control)
            {
                HistoryForm history = new HistoryForm(_manager.HistoryTextBox);
                history.ShowDialog();
            }
            if (e.KeyCode == Keys.C && e.Control)
            {
                CalculationForm calculation = new CalculationForm(_figures);
                calculation.ShowDialog();
            }
            if (e.KeyCode == Keys.D && e.Control)
            {
                DocumentationForm documentation = new DocumentationForm();
                documentation.ShowDialog();
            }
            if (e.KeyCode == Keys.O && e.Control)
            {
                OpenFile();
            }
            if (e.KeyCode == Keys.S && e.Control && e.Shift)
            {
                SaveAsFile();
            }
        }
        private void mainLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMovable && (_selectedFigure != null && e.Button == MouseButtons.Left))
            {
                int dx = e.X - _lastMousePos.X;
                int dy = e.Y - _lastMousePos.Y;
                _selectedFigure.Move(dx, dy);
                _lastMousePos = e.Location;
                mainLayout.Invalidate();
            }
        }
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //Finding Area and editing figure
            if (e.Button == MouseButtons.Middle)
            {
                for (int i = 0; i < _figures.Count; i++)
                {
                    var figure = _figures[i];
                    if (figure.Contains(e.Location))
                    {
                        var oldV = figure.Clone();
                        CurrFigureInfo curr = new CurrFigureInfo(figure, _dpiX, _dpiY);
                        curr.ShowDialog();

                        ICommand editing = new EditingCommand(curr.Figure, oldV);
                        _manager.ExecuteCommand(editing);
                        break;
                    }
                }
            }

            //Filling
            if (e.Button == MouseButtons.Right && _isReadyForFilling)
            {
                foreach (Figure figure in _figures)
                {
                    if (figure.Contains(e.Location))
                    {
                        ICommand draw = new FillCommand(figure, _currColor);
                        _manager.ExecuteCommand(draw);
                    }
                }
            }
            //Movement
            if (_isMovable && !_isReadyForFilling)
            {
                foreach (Figure figure in _figures.OrderBy(x => x.Width))
                {
                    if (figure.Contains(e.Location))
                    {
                        _selectedFigure = figure;
                        _lastMousePos = e.Location;
                        _x = figure.X;
                        _y = figure.Y;
                        break;
                    }
                }
            }
            //Drawing
            if (e.Button == MouseButtons.Left && !_isReadyForFilling)
            {
                _startPoint = e.Location;
            }

            mainLayout.Invalidate();
            Refresh();
        }
        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //Drawing
            if (e.Button == MouseButtons.Left && !_isMovable)
            {
                _endPoint = e.Location;
                DrawShape(_startPoint, _endPoint, e);
            }
            //Movement Undo Feature
            if (_isMovable && (_selectedFigure != null && e.Button == MouseButtons.Left))
            {
                ICommand move = new MoveCommand(_selectedFigure, _x, _y);
                _manager.ExecuteCommand(move);
            }

            _selectedFigure = null;
            mainLayout.Invalidate();
            Refresh();
        }



        //Methods
        private void DrawShape(Point start, Point end, MouseEventArgs e)
        {
            switch (_currentDrawingMode)
            {
                case DrawingMode.Rectangle:
                    GetRectangle(start, end);
                    break;
                case DrawingMode.Move:
                    _isMovable = true;
                    break;
                case DrawingMode.Square:
                    GetSquare(start, end);
                    break;
                case DrawingMode.Line:
                    GetLine(start, end);
                    break;
                case DrawingMode.Eraser:
                    EraseFigure(e);
                    break;
                case DrawingMode.Fill:
                    _isReadyForFilling = true;
                    break;
                case DrawingMode.Ellipse:
                    GetEllipse(start, end);
                    break;
            }
        }

        private void EraseFigure(MouseEventArgs e)
        {
            foreach (Figure figure in _figures.OrderBy(x => x.Width))
            {
                if (figure.Contains(e.Location))
                {
                    RemoveFigure(figure);
                    Invalidate();
                    break;
                }
            }
        }

        private void GetRectangle(Point start, Point end)
        {
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);

            if (!_isMovable)
            {
                var model = new Modules.Rectangle(
                x, y, width, height,
                _currColor,
                Color.Transparent
            );
                AddFigure(model);
            }
        }

        private Square GetSquare(Point start, Point end)
        {
            int sideLength = Math.Min(Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y));
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            var model = new Square(x, y, sideLength, sideLength, _currColor, Color.Transparent);
            AddFigure(model);
            return model;
        }

        private Line GetLine(Point start, Point end)
        {
            int width = Math.Abs(end.X - start.X);
            int height = Math.Abs(end.Y - start.Y);
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            var model = new Line(start, end, x, y, width, height, _currColor, Color.Transparent);
            AddFigure(model);

            return model;
        }

        private void GetEllipse(Point start, Point end)
        {
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);

            if (!_isMovable)
            {
                var model =
                    new Ellipse(
                        x,
                        y,
                        width,
                        height,
                        _currColor,
                        Color.Transparent
            );
                AddFigure(model);
            }
        }

        private void SelectButton(Button selectedButton)
        {
            selectedButton.FlatAppearance.BorderSize = 3;

            foreach (Control control in Controls)
            {
                if (lastSelectedButton != null && lastSelectedButton != selectedButton)
                {
                    lastSelectedButton.FlatAppearance.BorderSize = 0;
                }
                lastSelectedButton = selectedButton;
            }
        }

        private void SaveAsFile()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Data files (*.dat)|*.dat|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SerializeFigures(dialog.FileName);
                        _figures.Clear();
                        mainLayout.Invalidate();
                        MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }
        private void SerializeFigures(string filename)
        {
            try
            {
                using (FileStream stream = new FileStream(filename, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, _figures);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Figure> DeserializeFigures(string filename)
        {
            List<Figure> deserializedFigures = new List<Figure>();
            try
            {
                if (File.Exists(filename))
                {
                    using (FileStream stream = new FileStream(filename, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        deserializedFigures = (List<Figure>)formatter.Deserialize(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return deserializedFigures;
        }

        private void OpenFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Data files (*.dat)|*.dat|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _figures.Clear();
                        _figures.AddRange(DeserializeFigures(dialog.FileName));
                        mainLayout.Invalidate();
                        MessageBox.Show("File loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void pngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap bitmap = new Bitmap(mainLayout.Width, mainLayout.Height);
                        mainLayout.DrawToBitmap(bitmap, mainLayout.ClientRectangle);
                        bitmap.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void jpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "JPEG files (*.jpeg)|*.jpeg|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap bitmap = new Bitmap(mainLayout.Width, mainLayout.Height);
                        mainLayout.DrawToBitmap(bitmap, mainLayout.ClientRectangle);
                        bitmap.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

