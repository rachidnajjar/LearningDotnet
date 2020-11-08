namespace AreaCalculator.Models
{
    public class Rectangle
    {
        public int Lenght { get; set; }
        public int Breadth { get; set; }
        public int CalculateArea()
        {
            return Lenght * Breadth;
        }
    }
}