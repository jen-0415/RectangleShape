// See https://aka.ms/new-console-template for more information
using System;

namespace RectangleShape {
    class Rectangle {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width) {
            if (length <= 0 || width <= 0) {
                throw new ArgumentException("Length and width must be positive numbers.");
            }
            Length = length;
            Width = width;
        }

        public double GetArea() {
            return Length * Width;
        }

        public double GetPerimeter() {
            return 2 * (Length + Width);
        }

        public void Display() {
            Console.WriteLine($"\nLength: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
        }

        static void Main(string[] args) {
            Console.Write("Enter the length of the rectangle: ");
            double userLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double userWidth = Convert.ToDouble(Console.ReadLine());

            try {
                Rectangle rect = new Rectangle(userLength, userWidth);
                rect.Display();
            }
            catch (ArgumentException ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

