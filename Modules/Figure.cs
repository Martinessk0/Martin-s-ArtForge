using System.Text.Json.Serialization;

namespace FinalProject.Modules
{
    [Serializable]
    public abstract class Figure : IFigure
    {
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

        public Point Start { get; set; }
        public Point End { get; set; }


        public abstract Figure Clone();

        public abstract double CalculasArea();

        public abstract void Draw(Graphics graphics, Pen pen);

        public abstract bool Contains(Point point);

        public virtual void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public abstract void Fill(Graphics g, Brush brush);

        public override string ToString()
        {
            return $"{this.GetType().Name} -> Color: Outline{OutlineColor} Fill{FillColor} Location:{X} {Y}";
        }
    }
}
 