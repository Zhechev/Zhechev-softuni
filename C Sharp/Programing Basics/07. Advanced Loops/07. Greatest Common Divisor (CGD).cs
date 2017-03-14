using System;


namespace P7.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (a!=b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
                
            }
            Console.WriteLine(a);
        }
    }
}
