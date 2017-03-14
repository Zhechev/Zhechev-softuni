using System;


namespace P10.Half_Sum_Element
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var biggestNumber = -10000;
            var sumAll = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > biggestNumber)
                {
                    biggestNumber = num;
                }
                sumAll = sumAll + num;
            }
            if (biggestNumber == sumAll - biggestNumber)
            {
                Console.WriteLine("Yes sum = " + biggestNumber);
            }
            else
            {
                var diff = biggestNumber - (sumAll - biggestNumber);
                Console.WriteLine("No Diff = " + Math.Abs(diff));
            }
        

    }




}
}


