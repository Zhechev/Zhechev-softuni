using System;

class InstructionSet_broken
{
    static void Main()
    {
        { 
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int int1 = int.Parse(Console.ReadLine());
            char char1 = char.Parse(Console.ReadLine());
            long long1 = long.Parse(Console.ReadLine());
            long long2 = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + str1);
            Console.WriteLine("Last name: " + str2);
            Console.WriteLine("Age: " + int1);
            Console.WriteLine("Gender: " + char1);
            Console.WriteLine("Personal ID: " + long1);
            Console.WriteLine("Unique Employee number: " + long2);

        }
    }
}