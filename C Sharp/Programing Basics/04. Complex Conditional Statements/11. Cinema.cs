using System;


namespace P10.Cinema
{
    class Program
    {
        static void Main()
        {
            var show = Console.ReadLine().ToLower();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var price = 1d;
            
            if (show == "premiere")
            {
                price = r * c * 12;
            }
            else if (show == "normal")
            {
                price = r * c * 7.50;
            }
            else if (show == "discount")
            {
                price = r * c * 5;
            }
            Console.WriteLine("{0:F2} leva", price);
        }
    }
}
