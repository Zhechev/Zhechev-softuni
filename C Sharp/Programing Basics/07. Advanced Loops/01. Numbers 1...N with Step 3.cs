using System;


namespace P1.Numbers_1._._.N_with_Step_3
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
