using System;


namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var sumnum = 0;
            var sumnum2 = 0;
            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                sumnum = sumnum + x;

            }
            
            for (int j = 0; j < n; j++)
            {
                var num2 = int.Parse(Console.ReadLine());
                sumnum2 = sumnum2 + num2;
                
            }
            if (sumnum == sumnum2)
            {
                Console.WriteLine("Yes, sum = {0}", sumnum);
            }
            else
            {
                var diff = sumnum - sumnum2;
                Console.WriteLine("No, diff =" + Math.Abs(diff));
            }
          

            
            



        }
    }
}

