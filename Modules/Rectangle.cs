using System.Drawing;

namespace FinalProject.Modules
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int width, int height,Color outlineColor,Color fillColor) 
            : base(x,y,width,height, outlineColor, fillColor)
        {
        }

        public override double CalculasArea()
        {
            this.Area = WidthInCm * HeightInCm;
            return Area;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, X, Y, Width, Height);
        }

        public override bool Contains(Point point)
        {
            int x = point.X;
            int y = point.Y;
            return X <= x && x < X + Width && Y <= y && y < Y + Height;
        }

        public override void Fill(Graphics g, Brush brush)
        {
            g.FillRectangle(brush, X, Y, Width, Height);
        }

        public override Figure Clone()
        {
            return new Rectangle(X, Y, Width, Height, FillColor, OutlineColor);
        }
    }
}
