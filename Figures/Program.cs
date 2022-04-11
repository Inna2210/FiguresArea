using System;
using FigureInformationLibrary;
using System.Collections.Generic;
using System.Linq;

namespace Figures
{
        public class Program
        {
            static void Main(string[] args)
            {
                do
                {
                    int optionFigureType = 0;
                    do
                    {
                        Console.WriteLine("Вы хотите найти площадь треугольника или круга?");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(" 1 - площадь круга\t 2 - площадь треугольника");
                        Console.ForegroundColor = ConsoleColor.White;
                        optionFigureType = Convert.ToInt32(Console.ReadLine());
                        if (optionFigureType == 1 | optionFigureType == 2)
                        {
                            break;
                        }
                        Console.WriteLine("Сосредоточьтесь!");
                    }
                    while (optionFigureType != 1 | optionFigureType != 2);


                    if (optionFigureType == 1)
                    {
                        Console.WriteLine("Введите, пожалуйста, радиус круга");
                        FigureInformation figureInformation = new();
                        Circle circle = new(double.Parse(Console.ReadLine()));
                        double area = figureInformation.CalculateArea(circle);
                        Console.WriteLine($"Площадь круга с заданным радиусом составляет {area}.");
                    }

                    if (optionFigureType == 2)
                    {
                        Console.WriteLine("Введите, пожалуйста, стороны треугольника через пробел или двоеточие");
                        FigureInformation figureInformation = new();
                        Triangle triangle = new(Console.ReadLine().Split(' ', ':', '\t').Select(i => Convert.ToInt32(i)).ToList());
                        double area = figureInformation.CalculateArea(triangle);
                        Console.WriteLine($"Площадь треугольника с заданными сторонами составляет {area}.");

                        Console.WriteLine("Вы хотите проверить является ли треугольник прямоугольным?");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(" 1 - да\t 2 - нет");
                        Console.ForegroundColor = ConsoleColor.White;
                        int optionTypeTriangle = Convert.ToInt32(Console.ReadLine());
                        if (optionTypeTriangle == 1)
                        {
                            bool type = triangle.CheckTriangleType(triangle);
                            if (type == true)
                            {
                                Console.WriteLine("Треугольник является прямоугольным");
                            }

                            else
                            {
                                Console.WriteLine("Треугольник НЕ является прямоугольным");
                            }
                        }

                    }

                }
                while (true);
            }
        }
    
}
