using System;


namespace CelsiustoFahrenheit
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var result = ((a * 9) / 5) + 32;
            Console.WriteLine("{0:F2}", result);
        }
    }
}

