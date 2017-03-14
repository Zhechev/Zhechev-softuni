using System;

public class Time
{
    public static void Main(string[] args)
    {
        var hour = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        var sum = ((hour * 60) + minutes + 15);
        var resulthour = sum / 60;
        if (resulthour >= 24)
        {
            resulthour -= 24;

        }
        var resultmin = sum % 60;


        Console.WriteLine("{0}:{1:00}", resulthour, resultmin);
    }
}
