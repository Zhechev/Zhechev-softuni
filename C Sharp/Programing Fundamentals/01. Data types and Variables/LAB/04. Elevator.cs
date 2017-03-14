using System;


namespace P5.Elevator
{
    class Program
    {
        static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling ((double)persons / capacity);
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
