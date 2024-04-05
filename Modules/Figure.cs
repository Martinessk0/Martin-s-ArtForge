using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace FinalProject.Modules
{
    [Serializable]
    public abstract class Figure
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


        public Figure DeepClone()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Създаваме BinaryFormatter за сериализация
                IFormatter formatter = new BinaryFormatter();

                // Сериализираме текущия обект в memoryStream
                formatter.Serialize(memoryStream, this);

                // Позиционираме показателя на паметта в началото
                memoryStream.Seek(0, SeekOrigin.Begin);

                // Десериализираме обекта от memoryStream и връщаме копие
                return (Figure)formatter.Deserialize(memoryStream);
            }
        }

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
