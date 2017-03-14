using System;


namespace TriangleOf55Stars
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var sum1 = 0;
            int sum2 = 0;
            int diff = 0;
            int maxdiff = 0;
            for (int i = 0; i < input; i++)
            {
                int number1= int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                
                
                if (i == 0)
                {
                    sum1 = number1 + number2;
                }
                else
                {
                    sum2 = number1 + number2;
                    diff = Math.Abs(sum2 - sum1);
                    if (diff > maxdiff)
                    {
                        maxdiff = diff;
                    }
                    sum1 = sum2;
                }
                

            }
            if (diff == 0)
            {
                Console.WriteLine("Yes, value = " + sum1);
            }
            else
            {
                Console.WriteLine("No, maxdiff = " + maxdiff);
            }
            
            

        }
    }
}








