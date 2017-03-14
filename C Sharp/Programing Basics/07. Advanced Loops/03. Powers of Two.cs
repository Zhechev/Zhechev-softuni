using System;


namespace P3.Powers_of_Two
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; i <=n; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
           
        }
    }
}

