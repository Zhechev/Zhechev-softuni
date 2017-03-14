using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());
            double strana1 = Math.Abs(a - c);
            double strana2 = Math.Abs(d - b);
            var plosht = strana1 * strana2;
            var area = 2 * (strana1 + strana2);
            Console.WriteLine(plosht);
            Console.WriteLine(area);

        }
    }
}

