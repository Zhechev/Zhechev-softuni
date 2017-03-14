using System;


namespace Simple_Conditions
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
        }
    }
}
