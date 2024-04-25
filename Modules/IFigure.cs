using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Modules
{
    
    public interface IFigure
    {
        bool IsFill { get; set; }
        Color OutlineColor { get; set; }
        Color FillColor { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int Height { get; set; }
        int Width { get; set; }
        double HeightInCm { get; set; }
        double WidthInCm { get; set; }
        double Area { get; set; }

        Figure Clone();
        double CalculasArea();
        void Draw(Graphics graphics, Pen pen);
        bool Contains(Point point);
        void Move(int dx, int dy);
        void Fill(Graphics g, Brush brush);
        string ToString();
    }
}
