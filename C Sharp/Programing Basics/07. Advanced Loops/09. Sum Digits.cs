using System;


namespace P9.Sum_Digits
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0;
            var ss = 0;
            while (n!=0)
            {
                num = n % 10;
                ss = ss + num;
                n = n / 10;
            }
            Console.WriteLine(ss);
        }
    }
}
