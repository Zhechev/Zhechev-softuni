using System;


namespace RadianstoDegrees
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var result = Math.Round(a * 180 / Math.PI);
            Console.WriteLine(result);
            
        }
    }
}
