using System;
using System.Collections.Generic;


namespace FigureInformationLibrary
{
    public class FigureInformation
    {
        public double CalculateArea(Circle circle)
        {
            double area = Math.PI * circle.GetRadius() * circle.GetRadius();
            return area; 
        }

        public double CalculateArea(Triangle triangle)
        {
            List<int> sides = triangle.GetSides();
            double side1 = sides[0];
            double side2 = sides[1];
            double side3 = sides[2];
            double semiPerimeter = ((side1 + side2 + side3) / 2);
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            return area;
        }
    }

    
    public class Circle
    {
        public double radius;

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double value)
        {
            radius = value;
        }

        public Circle(double radius)
        {
            this.SetRadius(radius);
        }
    }

    public class Triangle
    {
        
        List<int> sides = new();

        public Triangle(List<int> sides)
        {
            this.SetSides(sides);
        }

        public List<int> GetSides()
        {
            return sides;
        }

        public void SetSides(List<int> value)
        {
            sides = value;
        }

        public bool CheckTriangleType(Triangle triangle)
        {
            List<int> sides = triangle.GetSides();
            sides.Sort();
            double side1 = sides[0];
            double side2 = sides[1];
            double side3 = sides[2];
            bool type;
            if (side3 * side3 == side1 * side1 + side2 * side2)
            {
                type = true;
            }
            else
            {
                type = false;
            }
            return type;
        }
    }
}
