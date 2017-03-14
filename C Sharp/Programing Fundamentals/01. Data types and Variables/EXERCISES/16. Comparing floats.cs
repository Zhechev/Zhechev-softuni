using System;

class InstructionSet_broken
{
    static void Main()
    {
        {
            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());
            float difference = Math.Abs((firstNumber - secondNumber));
            double differenceRound = Math.Round(difference, 7);
            double epss = 0.000001;

            if (differenceRound < epss)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

}
