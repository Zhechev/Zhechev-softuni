using System;


namespace P4.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0M;

            for (int i = 0; i < n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
                
            }
            Console.WriteLine(sum);
        }

    }
}
