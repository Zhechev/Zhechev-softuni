using System;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            decimal milliseconds = seconds * 1000M;
            decimal microseconds = milliseconds * 1000M;
            decimal nanoseconds = microseconds * 1000M;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = { nanoseconds} nanoseconds ");
        }
    }
}