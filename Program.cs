using System;
namespace Exercise
{
    public interface Area
    {
        double GetArea();
    }
    public class Rectangle : Area
    {
        double height;
        double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public double GetArea()
        {
            return height * width;
        }
    }
    public class Program
    {
        static void Main(string[] args) 
        {
            Rectangle rectangle = new Rectangle(5.0,5.0);
            Console.WriteLine(rectangle.GetArea());
        }
    }
}