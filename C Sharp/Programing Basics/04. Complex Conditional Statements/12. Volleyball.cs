using System;


namespace P11.Voleyball
{
    class Program
    {
        static void Main()
        {
            var year = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var vladiTotalPlaySaturday = (48 - h) * (3.0 / 4.0);
            var vladiTotalPlayHolyday = p * 2.0 / 3.0;
            var vladiTotalPlay = vladiTotalPlaySaturday + vladiTotalPlayHolyday + h;
            var vladiTotalPlayLeapYear = vladiTotalPlay + (vladiTotalPlay * 0.15);
            if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(vladiTotalPlay));
            }
            else if (year == "leap")
            {
               
                Console.WriteLine(Math.Truncate(vladiTotalPlayLeapYear));

            }

        }
    }
}
