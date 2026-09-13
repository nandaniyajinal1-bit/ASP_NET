/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class ShapeArea
    {
 
        class Shape
        {
            public virtual double CalculateArea()
            {
                return 0;
            }
        }

        class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * radius * radius;
            }
        }

        class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public override double CalculateArea()
            {
                return length * width;
            }
        }

        class Triangle : Shape
        {
            private double baseLength;
            private double height;

            public Triangle(double baseLength, double height)
            {
                this.baseLength = baseLength;
                this.height = height;
            }

            public override double CalculateArea()
            {
                return 0.5 * baseLength * height;
            }
        }

        class TestShape
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Shape circle = new Circle(7);
                Shape rectangle = new Rectangle(10, 5);
                Shape triangle = new Triangle(9, 6);

                Console.WriteLine("Area of Circle    : " + circle.CalculateArea().ToString("F2"));
                Console.WriteLine("Area of Rectangle : " + rectangle.CalculateArea());
                Console.WriteLine("Area of Triangle  : " + triangle.CalculateArea());

                Console.ReadLine();
            }
        }
    }


}*/

