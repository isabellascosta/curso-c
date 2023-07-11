using ExercicioResolvido2.Entities;
using ExercicioResolvido2.Entities.Enums;
using System;
using System.Globalization;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n;i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Retangle or circle? (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color: (Black/Blue/Red: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(ch == 'r')
                {
                    Console.Write("With: ");
                    double with = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(with, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS: ");
                foreach( Shape shape in list)
                {
                    Console.WriteLine(shape.Area().ToString("f2",CultureInfo.InvariantCulture));
                }
            }

        }
    }
}