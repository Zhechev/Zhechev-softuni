using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var bonus = 0.0;

            if (number <= 100)
            {

                bonus = bonus + 5;
            } 
            else if (number > 1000)
            {
                bonus = bonus +  0.1 * number;
            }
            else if (number > 100)
            {
                bonus = bonus + 0.2 * number;

            }
            if (number % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (number % 10 == 5)
            {
                bonus = bonus + 2; 
            }
           
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
            

        }
    }
}

