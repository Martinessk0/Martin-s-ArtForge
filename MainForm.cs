using FinalProject.Modules;
using System.Reflection;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private Stack<List<Figure>> _undoStack = new Stack<List<Figure>>();
        private Stack<List<Figure>> _redoStack = new Stack<List<Figure>>();

        private readonly List<Figure> _figures = new List<Figure>();
        internal static DrawingMode _currentDrawingMode = DrawingMode.None;
        internal static Color _currColor = Color.Black;
        private Pen _drawingPen = new Pen(_currColor, 5);
        private Brush? _fillingBrush;
        private Point _startPoint;
        private Point _endPoint;
        private Figure? _selectedFigure = null;
        private Point _lastMousePos;
        internal static bool _isMovable = false;
        internal static bool _isReadyForFilling = false;
        internal static Button? _lastSelectedButton;
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainLayout_Paint(object sender, PaintEventArgs e)
        {
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


        private void MainForm_Load(object sender, EventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            mainLayout, new object[] { true });
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
        private void AddFigure(Figure figure)
        {
            _figures.Add(figure);
        }
        private void RemoveFigure(Figure figure)
        {
            _figures.Remove(figure);
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
            //Area
            if (e.Button == MouseButtons.Middle)
            {
                foreach (Figure figure in _figures.OrderBy(x => x.Width))
                {
                    if (figure.Contains(e.Location))
                    {
                        figure.CalculateArea();
                        MessageBox.Show(figure.Area.ToString());
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
                        figure.FillColor = _currColor;
                        figure.IsFill = true;
                        Invalidate();
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
            AddToUndoStack();
        }
        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _selectedFigure = null;

            //Drawing
            if (e.Button == MouseButtons.Left)
            {
                _endPoint = e.Location;
                DrawShape(_startPoint, _endPoint, e);
            }
            mainLayout.Invalidate();
            Refresh();
            AddToUndoStack();
        }

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
                case DrawingMode.Circle:
                    GetCircle(start, end);
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
                    Invalidate();
                    AddToUndoStack();
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

        private void GetCircle(Point start, Point end)
        {
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);

            if (!_isMovable)
            {
                var model =
                    new Circle(
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

        internal static void SelectButton(Button selectedButton)
        {
            selectedButton.FlatAppearance.BorderSize = 3;

            foreach (Control control in selectedButton.Parent.Controls)
            {
                if (_lastSelectedButton != null && _lastSelectedButton != selectedButton)
                {
                    _lastSelectedButton.FlatAppearance.BorderSize = 0;
                }
                _lastSelectedButton = selectedButton;
            }
        }

        private void Undo()
        {
            if (_undoStack.Count > 0)
            {
                var currentState = new List<Figure>(_figures);
                _redoStack.Push(currentState);

                _figures.Clear();
                _figures.AddRange(_undoStack.Pop());

                mainLayout.Invalidate();
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
            }
        }

        private void AddToUndoStack()
        {
            var currentState = new List<Figure>(_figures);
            _undoStack.Push(currentState);
            _redoStack.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShapesForm shapes = new ShapesForm();
            shapes.ShowDialog();
            //Redo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }
    }
}
