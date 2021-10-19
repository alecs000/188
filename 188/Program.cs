using System;

namespace _188
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            double d = Math.Sqrt( b * b - 4 * a * c);
            double x1 = 0;
            double x2 = 0;
            if (d>=0)
            {
                x1 = (-b + d) / 2 * a;
                x2 = (-b - d) / 2 * a;
            }
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
