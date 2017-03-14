using System;


namespace P5.Invalid_Number
{
    class Program
    {
        static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var inRange = (num >= 100 && num <= 200);
            var zero = (num == 0);
            var valid = inRange || zero;
                if (!valid)
            {
                Console.WriteLine("Invalid");
            }

            //var number = int.Parse(Console.ReadLine());
            //if  (number > 200 || number < 100 && number != 0)
            //{
            //    Console.WriteLine("invalid");
            //}
        }
    }
}
