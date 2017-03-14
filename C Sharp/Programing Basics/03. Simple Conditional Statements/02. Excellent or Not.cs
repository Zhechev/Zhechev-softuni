using System;
using System.Collections.Generic;

namespace Excellent_or_Not
{
    class Program
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            if (number >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not Excellent."); 
            }
        }
    }
}
