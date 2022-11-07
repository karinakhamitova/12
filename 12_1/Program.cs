using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для определения параметров круга введите радиус:");
            double r = Convert.ToDouble(Console.ReadLine());
            double p = Circle.GetLength(r);
            double s = Circle.GetArea(r);
            Console.WriteLine($"Длина окружности - {p}, площадь круга - {s}");
            Console.WriteLine("Поверка принадлежности точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0. Введите значения координат центра и точки:  ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Circle.CheckСoordinates(r, x0, y0, x, y));
            Console.ReadKey();
        }
    }
}
