using System;


namespace P4.Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum =  sum + num;
                
            }
            Console.WriteLine(sum);
        }
    }
}
