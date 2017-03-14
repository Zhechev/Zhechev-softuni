using System;


namespace USD_to_BGN
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var result = a * 1.79549;
            Console.WriteLine("{0:F2}", result);
        }
    }
}

