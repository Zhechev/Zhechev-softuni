using System;


namespace TriangleOf55Stars
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sumOdd = 0;
            var sumEven = 0;
            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOdd = sumOdd + num1;
                }
                else
                {
                    sumEven = sumEven + num1;
                }

            }
            if (sumOdd == sumEven)
            {
               
                Console.WriteLine("Yes sum =" + sumOdd);
            }
            else
            {
                var totalDiff = sumOdd - sumEven;
                Console.WriteLine("No Diff= " + Math.Abs(totalDiff));
            }




        }



    }
}




