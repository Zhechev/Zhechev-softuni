using System;


namespace P3.Circle_Area
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double result = Math.PI * r * r;
            Console.WriteLine($"{result:f12}");
        }
    }
}
