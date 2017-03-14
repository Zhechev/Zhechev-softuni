using System;


namespace Numbers_100._._200
{
    class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else 
            {
                Console.WriteLine("Greater than 200");
            }

        }
    }
}
