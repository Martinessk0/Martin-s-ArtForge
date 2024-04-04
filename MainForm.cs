using FinalProject.Modules;
using System.Reflection;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private readonly Stack<Action> _undoStack = new Stack<Action>();
        private readonly Stack<Action> _redoStack = new Stack<Action>();

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
            lblCurrColor.BackColor = _currColor;
            pickColor.FlatAppearance.MouseOverBackColor = pickColor.BackColor;
            pickColor.FlatAppearance.MouseDownBackColor = pickColor.BackColor;
            //Preventing lagging when moving the figures
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            mainLayout, new object[] { true });
        }
        private void btnRectangular_Click(object sender, EventArgs e)
        {
            SelectButton(btnRectangular);
            _isReadyForFilling = false;
            _isMovable = false;
            _currentDrawingMode = DrawingMode.Rectangle;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            SelectButton(btnCircle);
            _isReadyForFilling = false;
            _isMovable = false;
            _currentDrawingMode = DrawingMode.Circle;
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


    }
}
