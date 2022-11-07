using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1
{
    static class Circle
    {
        public static double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        public static double GetArea(double r)
        {
            return Math.PI * r * r;
        }
        public static string CheckСoordinates(double r, double x0, double y0, double x, double y)
        {
            if (Math.Sqrt(Math.Pow(x -x0,2)+ Math.Pow(y - y0, 2))>r)
            {
                return "Точка выходит за границы круга";
            }
            return "Точка находится внутри круга";
        }
    }
}
