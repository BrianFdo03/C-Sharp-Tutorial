using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // a)	Create an instance of the Rectangle class representing a rectangle with a length of 5 and a width of 3.
            Rectangle rectangle = new Rectangle(5, 3);

            // b)	Display the shape information for the rectangle.
            Console.WriteLine();
            rectangle.DisplayShapeInfo();

            // c)	Create an instance of the Circle class representing a circle with a radius of 4.
            Console.WriteLine();
            Circle circle = new Circle(4);

            // d)	Display the shape information for the circle.
            Console.WriteLine();
            circle.DisplayShapeInfo();

        }
    }

    class Shape
    {
        public string ShapeType;
        public double Area;

        public Shape()
        {
            this.ShapeType = "Shape";
            Area = 0;
        }

        public virtual void CalculateArea(double val1, double val2)
        {

        }

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine("Shape type : " + ShapeType);
            Console.WriteLine("Shape area : " + Area);
        }
    }

    class Rectangle : Shape
    {
        double length;
        double width;

        public Rectangle(double length, double width)
        {
           ShapeType = "Rectangle";
           SetDimensions(length, width);
        }

        public void SetDimensions(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea(length, width);
        }

        public override void CalculateArea(double val1, double val2)
        {
            Area = val1 * val2;
            // Console.WriteLine("Area of Rectangle : " + Area + " square units");
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine("Shape Length " + length);
            Console.WriteLine("Shape Width " + width);
            base.DisplayShapeInfo();
        }
    }

    class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            ShapeType = "Circle";
            SetRadius(radius);
        }

        public void SetRadius(double radi)
        {
            this.radius = radi;
            CalculateArea(radi);
        }

        public void CalculateArea(double radi)
        {
            Area = 3.14 * radi * radi;
            // Console.WriteLine("Area of Circle : " + Area + " square units");
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine("Shape Radius " + radius);
            base.DisplayShapeInfo();
        }
    }
}
