using System;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {

            int n = int.Parse(Console.ReadLine());
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (n > 0 && n <= 7)
            {
                Console.WriteLine(days[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }

    }

}
