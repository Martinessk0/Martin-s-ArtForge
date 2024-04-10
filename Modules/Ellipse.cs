namespace FinalProject.Modules
{
    public class Ellipse : Figure
    {
        public Ellipse(int x, int y, int width, int height, Color outlineColor, Color fillColor)
            : base(x, y, width, height, outlineColor, fillColor)
        {
        }

        public override double CalculasArea()
        {
            Area =  Math.PI * (WidthInCm / 2.0) * (HeightInCm / 2.0);
            return Area;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, X, Y, Width, Height);
        }

        public override bool Contains(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - (X + Width / 2.0), 2) + Math.Pow(point.Y - (Y + Height / 2.0), 2));
            return distance <= Width / 2.0;
        }

        public override void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public override void Fill(Graphics g, Brush brush)
        {
            g.FillEllipse(brush, X, Y, Width, Height);
        }

        public override Figure Clone()
        {
            return new Ellipse(X, Y, Width, Height, FillColor, OutlineColor);
        }
    }
}
