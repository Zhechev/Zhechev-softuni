using System;


namespace P1.Personal_Titles
{
    class Program
    {
        static void Main()
        {
                        string animal = Console.ReadLine().ToLower();

            
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                    default:
                        Console.WriteLine("unknown");
                        break;
            }
        }
    }
}
