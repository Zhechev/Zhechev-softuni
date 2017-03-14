using System;


namespace P2.Small_Shop
{
    class Program
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.50);
                }
                else if (product == "water")
                {
                    Console.WriteLine(amount * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(amount * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(amount * 1.45);
                }
                else if (product == "peanuts") 
                {
                    Console.WriteLine(amount * 1.60);
                }
            }
            if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine(amount * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(amount * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(amount * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(amount * 1.50);
                }
            }
            if (town == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(amount * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(amount * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(amount * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(amount * 1.55);
                }
            }
        }
    }
}
