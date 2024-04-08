using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


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


        public Figure DeepClone()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Create a BinaryFormatter for serialization
                IFormatter formatter = new BinaryFormatter();

                // Serialize the current object into memoryStream
                formatter.Serialize(memoryStream, this);

                // Reset the memoryStream position to the beginning
                memoryStream.Seek(0, SeekOrigin.Begin);

                // Deserialize the object from memoryStream
                Figure clonedFigure = (Figure)formatter.Deserialize(memoryStream);

                // Perform a deep copy by creating new instances of referenced objects
                // Assuming Figure class has properties that need to be deep copied, do it here

                // For example:
                // clonedFigure.SomeProperty = new SomePropertyType(this.SomeProperty);

                // Return the cloned object
                return clonedFigure;
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

        public override string ToString()
        {
            return $"{this.GetType().Name} -> Color: Outline{OutlineColor} Fill{FillColor} Location:{X} {Y}";
        }
    }
}
 