using FinalProject.Modules;
using System.Reflection;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private readonly Stack<List<Figure>> _undoStack = new Stack<List<Figure>>();
        private readonly Stack<List<Figure>> _redoStack = new Stack<List<Figure>>();
        private readonly List<Figure> _figures = new List<Figure>();
        private DrawingMode _currentDrawingMode = DrawingMode.None;
        private static Color _currColor = Color.Black;
        private Pen _drawingPen = new Pen(_currColor, 5);
        private Brush? _fillingBrush;
        private Point _startPoint;
        private Point _endPoint;
        private Figure? _selectedFigure = null;
        private Point _lastMousePos;
        private bool _isMovable = false;
        private bool _isReadyForFilling = false;
        private Button lastSelectedButton;
        private ListBox _historyListBox = new ListBox();
        private const double cmToInch = 2.54;
        private double dpiX, dpiY;

        public MainForm()
        {
            InitializeComponent();
        }



        //Paint Event
        private void mainLayout_Paint(object sender, PaintEventArgs e)
        {
            dpiX = e.Graphics.DpiX;
            dpiY = e.Graphics.DpiY;

            if (_undoStack.Count > 0)
                undoToolStripMenuItem.Enabled = true;
            else
                undoToolStripMenuItem.Enabled = false;

            if (_redoStack.Count > 0)
                redoToolStripMenuItem.Enabled = true;
            else
                redoToolStripMenuItem.Enabled = false;

            foreach (Figure f in _figures)
            {
                _drawingPen.Color = f.OutlineColor;
                f.Draw(e.Graphics, _drawingPen);
                if (f.IsFill)
                {
                    _fillingBrush = new SolidBrush(f.FillColor);
                    f.Fill(e.Graphics, _fillingBrush);
                }
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
            Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }
        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentationForm documentation = new DocumentationForm();
            documentation.ShowDialog();
        }
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm(_historyListBox);
            history.ShowDialog();
        }
        private void AddFigure(Figure figure)
        {
            _figures.Add(figure);
        }
        private void RemoveFigure(Figure figure)
        {
            _figures.Remove(figure);
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
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Control)
            {
                Undo();
            }
            if (e.KeyCode == Keys.X && e.Control)
            {
                Redo();
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
            //Finding Area
            if (e.Button == MouseButtons.Middle)
            {
                foreach (Figure figure in _figures)
                {
                    if (figure.Contains(e.Location))
                    {
                        //Converter Px in Cm
                        figure.WidthInCm = PixelsToCM(figure.Width, dpiX);
                        figure.HeightInCm = PixelsToCM(figure.Height, dpiY);
                        figure.CalculasArea();
                        MessageBox.Show($"The area of {figure.GetType().Name} is {Math.Round(figure.Area, 2)} cm2");

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
                        figure.FillColor = _currColor;
                        figure.IsFill = true;
                        Invalidate();
                        AddToUndoStack();
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
                        break;
                    }
                }
            }
            //Drawing
            if (e.Button == MouseButtons.Left && !_isReadyForFilling)
            {
                _startPoint = e.Location;
            }
        }
        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //Drawing
            if (e.Button == MouseButtons.Left && !_isMovable)
            {
                _endPoint = e.Location;
                DrawShape(_startPoint, _endPoint, e);
                AddToUndoStack();
            }
            //Movement Undo Feature
            if (_isMovable && (_selectedFigure != null && e.Button == MouseButtons.Left))
            {
                AddToUndoStack();
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
                    _selectedFigure = figure;
                    RemoveFigure(figure);
                    AddToUndoStack();
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

        private double PixelsToCM(int pixels, double dpi)
        {
            return pixels / dpi * cmToInch;
        }

        private void Undo()
        {
            if (_undoStack.Count > 0)
            {
                _undoStack.Pop();
                var currentState = new List<Figure>(_figures);
                _redoStack.Push(currentState);

                _figures.Clear();
                if (_undoStack.Count > 0) _figures.AddRange(_undoStack.Peek());
                mainLayout.Invalidate();
                UpdateHistoryDisplay();
            }
        }

        private void Redo()
        {
            if (_redoStack.Count > 0)
            {
                var currentState = new List<Figure>(_figures);
                _undoStack.Push(currentState);

                _figures.Clear();
                _figures.AddRange(_redoStack.Pop());
                mainLayout.Invalidate();
                UpdateHistoryDisplay();
            }
        }

        private void AddToUndoStack()
        {
            var currentState = new List<Figure>();
            foreach (var figure in _figures)
            {
                currentState.Add(figure.DeepClone());
            }
            _undoStack.Push(currentState);
            _redoStack.Clear();
            UpdateHistoryDisplay();
        }

        private void UpdateHistoryDisplay()
        {
            //_historyListBox.Items.Clear();
            foreach (var action in _undoStack)
            {
                foreach (var figure in action)
                {
                    _historyListBox.Text += "Undo";
                    _historyListBox.Text += Environment.NewLine;
                    _historyListBox.Text += figure.ToString();
                    _historyListBox.Text += Environment.NewLine;
                }
            }
            foreach (var action in _redoStack)
            {
                foreach (var figure in action)
                {
                    _historyListBox.Text += "Redo";
                    _historyListBox.Text += Environment.NewLine;
                    _historyListBox.Text += figure.ToString();
                    _historyListBox.Text += Environment.NewLine;
                }
            }

        }

    }
}
