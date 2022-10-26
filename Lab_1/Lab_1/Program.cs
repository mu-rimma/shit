using System;

namespace Lab_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите параметр а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите параметр b: ");
            double b = double.Parse(Console.ReadLine());
            double z1 = Math.Pow((Math.Cos(a) - Math.Cos(b)), 2) - Math.Pow((Math.Sin(a) - Math.Sin(b)), 2);
            double z2 = -4 * Math.Pow(Math.Sin((a - b) / 2), 2) * Math.Cos(a + b);
            Console.WriteLine($"z1: {z1:0.00}\nz2: {z2:0.00}");
        }
    }
}
