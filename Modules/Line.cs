using System.Security.Cryptography;

namespace FinalProject.Modules
{
    [Serializable]
    public class Line : Figure
    {
        public Line(Point start, Point end, int x, int y, int width, int height, Color outlineColor, Color fillColor)
            : base(x, y, width, height, outlineColor, fillColor)
        {
            this.Start = start;
            this.End = end;
        }


        public override double CalculasArea()
        {
            return 0;
        }
        public override bool Contains(Point point)
        {
            double distance = DistanceFromPointToLine(Start, End, point);
            return distance <= 2; // Adjust the threshold as needed
        }

        private double DistanceFromPointToLine(Point start, Point end, Point point)
        {
            double dx = end.X - start.X;
            double dy = end.Y - start.Y;
            double lengthSquared = dx * dx + dy * dy;

            if (lengthSquared == 0)
                return Math.Sqrt((point.X - start.X) * (point.X - start.X) + (point.Y - start.Y) * (point.Y - start.Y));

            double t = Math.Max(0, Math.Min(1, ((point.X - start.X) * dx + (point.Y - start.Y) * dy) / lengthSquared));
            double projectionX = start.X + t * dx;
            double projectionY = start.Y + t * dy;

            double distX = point.X - projectionX;
            double distY = point.Y - projectionY;

            return Math.Sqrt(distX * distX + distY * distY);
        }

        public override void Move(int dx, int dy)
        {
            Start = new Point(Start.X + dx, Start.Y + dy);
            End = new Point(End.X + dx, End.Y + dy);
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, Start, End);
        }

        public override void Fill(Graphics g, Brush brush)
        {
            MessageBox.Show("The line cannot be filled");
            IsFill = false;
        }

        public override Figure Clone()
        {
            return new Line(Start, End, X, Y, Width, Height, OutlineColor, FillColor);
        }
    }
}
