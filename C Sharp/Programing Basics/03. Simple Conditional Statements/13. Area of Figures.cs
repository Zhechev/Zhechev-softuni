using System;


namespace AreaOfFigures
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            if (input == "square")
            {
                var number = double.Parse(Console.ReadLine());
                var result = number * number;
                Console.WriteLine("{0:F3}", result);
            }
            if (input == "rectangle")
            {
                var number = double.Parse(Console.ReadLine());
                var number1 = double.Parse(Console.ReadLine());
                var result = number * number1;
                Console.WriteLine("{0:F3}", result);
            }

            if (input == "circle")
            {
                var number = double.Parse(Console.ReadLine());
                var result = Math.PI * number * number;
                Console.WriteLine("{0:F3}", result);
            }

            if (input == "triangle")
            {
                var number = double.Parse(Console.ReadLine());
                var number1 = double.Parse(Console.ReadLine());
                var result = number * (number1 / 2);
                Console.WriteLine("{0:F3}", result);
            }
        }
    }
}
