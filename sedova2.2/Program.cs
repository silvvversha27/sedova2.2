using System;

namespace sedova2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите координату x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координату y:");
            double y = double.Parse(Console.ReadLine());
            if (1>=y*y+Math.Pow(x-1,2)) Console.WriteLine("Точка попадает в область.");
            else Console.WriteLine("Точка не попадает в область");
        }
    }
}
