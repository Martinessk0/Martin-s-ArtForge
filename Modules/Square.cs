﻿namespace FinalProject.Modules
{
    public class Square : Figure
    {
        public Square(int x, int y, int width, int height, Color outlineColor, Color fillColor)
            : base(x, y, width, height, outlineColor, fillColor)
        {
        }

        public override double CalculasArea()
        {
            this.Area = Width * Height;
            return Area;
        }

        public override bool Contains(Point point)
        {
            int x = point.X;
            int y = point.Y;
            return X <= x && x < X + Width && Y <= y && y < Y + Height;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, X, Y, Width, Height);
        }

        public override void Fill(Graphics g, Brush brush)
        {
            g.FillRectangle(brush, X, Y, Width, Height);
        }
    }
}