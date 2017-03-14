using System;

class InstructionSet_broken
{
    static void Main()
    {
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = 2 * (width + height);
            double perimeter = width * height;
            double diagonal = Math.Sqrt((width * width) + (height * height));
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            Console.WriteLine(diagonal);
        }
    }
}