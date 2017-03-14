using System;


namespace Sum_Seconds
{
    class Program
    {
        static void Main()
        {
            var player1 = double.Parse(Console.ReadLine());
            var player2 = double.Parse(Console.ReadLine());
            var player3 = double.Parse(Console.ReadLine());
            var sum = player1 + player2 + player3;
            var minutes = 0;


            if (sum < 59)
            {
                minutes = 0;
            }
            else if (sum >= 120)
            {
                sum = sum - 120;
                minutes = 2;
            }
            else if (sum >= 60)
            {
                sum = sum - 60;
                minutes = 1;
            }
            if (sum < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + sum);
            }
            else
            {
                Console.WriteLine(minutes + ":" + sum);
            }


        }

    }
}
