using System;

namespace ЛР_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Координаты Х точек А, В и С.
            double xa, xb, xc;
            // Координаты У точек А, В и С.
            double ya, yb, yc;
            // Ввод значений координат точек.
            Console.WriteLine("Введите координаты точки A : ");
            Console.WriteLine("X = ");
            xa = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y = ");
            ya = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B : ");
            Console.WriteLine("X = ");
            xb = Double.Parse(Console.ReadLine());
            Console.WriteLine("y = ");
            yb = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C : ");
            Console.WriteLine("X = ");
            xc = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y = ");
            yc = Double.Parse(Console.ReadLine());
            //Вычисление длин отрезков AB, BC b AC по формуле.
            double AB = Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)),4);
            double BC = Math.Round(Math.Sqrt(Math.Pow(xc - xb, 2) + Math.Pow(yc - yb, 2)), 4);
            double AC = Math.Round(Math.Sqrt(Math.Pow(xc - xa, 2) + Math.Pow(yc - ya, 2)), 4);
            // Вывод длин отрезков на консоль.
            Console.WriteLine("Расстояние от A до B = " + AB);
            Console.WriteLine("Расстояние от B до C = " + BC);
            Console.WriteLine("Расстояние от A до C = " + AC);
            Console.ReadLine();
        }
    }
}
