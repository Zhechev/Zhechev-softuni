using System;


namespace P5.Max_Number
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var maxx = 10000;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < maxx)
                {
                    maxx = num;
                }
            }
            Console.WriteLine(maxx);
        }
    }
}
