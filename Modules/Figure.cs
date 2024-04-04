namespace FinalProject.Modules
{
    public abstract class Figure
    {
        //private int _x;
        //private int _y;
        //private int _width;
        //private int _height;
        //private double _area;
        //private Color _outlineColor;
        //private Color _fillColor = Color.Transparent;
        //private Point _point;
        //private bool _isFill = false;

        protected Figure(int x, int y, int width, int height, Color color, Color colorFilling)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            OutlineColor = color;
            FillColor = colorFilling;
        }

        public bool IsFill { get; set; }
        public Color OutlineColor { get; set; }
        public Color FillColor { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public double HeightInCm { get; set; }
        public double WidthInCm { get; set; }

        public double Area { get; set; }
        public Point Point { get; set; }


        public abstract double CalculasArea();

        public abstract void Draw(Graphics graphics, Pen pen);

        public abstract bool Contains(Point point);

        public virtual void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public abstract void Fill(Graphics g, Brush brush);


    }
}
