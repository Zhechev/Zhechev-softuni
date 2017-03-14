using System;


namespace TriangleOf55Stars
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool prime = true;

            if (input < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= input / 2 ; i++)
                {
                    if (input % i == 0)
                    {
                        prime = false;
                        break;
                    }
                   
                }


               
            }
            if (prime == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

        }
    }
}








