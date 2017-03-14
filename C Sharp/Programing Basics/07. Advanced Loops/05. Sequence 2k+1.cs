using System;


namespace P5.Sequence_2k_1
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num = num * 2  + 1;
            }
                
             
        }
    }
}
