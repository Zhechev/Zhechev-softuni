using System;


namespace TriangleOf55Stars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i=0; i <=n/2; i++)
            {
                Console.WriteLine(num);
                num *= 4;
               
            }
        }
    }
}








