using System.Collections.Generic;
using Course.Entities.Abstratas;
using System;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enther the number of shapes: ");
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Shape#{i} data:");
                Console.Write("Reactangle or Circle (r/c)? ");
                char key = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue,Red): ");
                string s = Console.ReadLine();
                Color color = (Color)Enum.Parse(typeof(Color), s);
                if (key == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Shape shape = new Rectangles(width, height, color);
                    shapes.Add(shape);
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape shape = new Circle(radius, color);
                    shapes.Add(shape);
                }
            }

            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }

        }
    }
    enum Color
    {
        Black,
        Blue,
        Red
    }
}
