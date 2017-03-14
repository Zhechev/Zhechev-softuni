using System;


namespace P6.Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            while (n<1 || n>100)
            {
                Console.WriteLine("Invalid number");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is:{0}",n);
        }
    }
}
