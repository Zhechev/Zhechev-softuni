using System;


namespace P4.Fruit_or_Vegetable
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            if (input == "banana" || input == "apple" || input == "kiwi"
                || input == "cherry" || input == "lemon" || input == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (input == "tomato" || input == "cucumber" 
                || input == "pepper" || input == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
