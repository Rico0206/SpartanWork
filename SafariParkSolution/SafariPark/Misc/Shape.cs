namespace SafariPark
{
    public abstract class Shape
    {
        public abstract int CalculateArea();

        public override string ToString()
        {
            return $"This is a shape of {GetType()}";
        }
    }

    public class Rectangle : Shape
    {

        public int Width { get; set; }
        public int Height { get; set; }

        public override int CalculateArea()
        {
            return Width * Height;
        }
    }
}
