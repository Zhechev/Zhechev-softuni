using System;


namespace Triangle_Area
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var result = a * h / 2;
            Console.WriteLine("{0:F2}", result);


        }
    }
}

