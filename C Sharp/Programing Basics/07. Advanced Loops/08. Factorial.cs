using System;


namespace P8.Factorial
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int i = 1; i <= n; i++)
            {
                num = i * num;
            }
            Console.WriteLine(num);
        }
    }
}
