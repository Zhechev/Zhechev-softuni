using System;

namespace P8.Trade_Comissions
{
    class Program
    {
        static void Main()
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var com = 1d;

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                 
                    com = 0.05 * sales;
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    com = 0.07 * sales;
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    com = 0.08 * sales;
                }
                else if (sales >= 10000)
                {
                    com = 0.12 * sales;
                }
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {

                    com = 0.045 * sales;
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    com = 0.075 * sales;
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    com = 0.10 * sales;
                }
                else if (sales >= 10000)
                {
                    com = 0.13 * sales;
                }
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {

                    com = 0.055 * sales;
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    com = 0.08 * sales;
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    com = 0.12 * sales;
                }
                else if (sales >= 10000)
                {
                    com = 0.145 * sales;
                }
            }
            if (com != 1)
            Console.WriteLine("{0:F2}", com);
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
