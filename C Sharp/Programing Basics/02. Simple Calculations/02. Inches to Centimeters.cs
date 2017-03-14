using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main()
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var result = inches * 2.54;
            Console.Write("Santimeters = ");
            Console.WriteLine(result);
        }
    }
}
