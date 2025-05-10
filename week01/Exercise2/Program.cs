using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter = "";

        if (percentage >= 90)
        {
            // Console.WriteLine("You got an A.");
            letter = "A";
        }
        else if (percentage >= 80)
        {
            // Console.WriteLine("You got a B.");
            letter = "B";
        }
        else if (percentage >= 70)
        {
            // Console.WriteLine("You got a C.");
            letter = "C";
        }
        else if (percentage >= 60)
        {
            // Console.WriteLine("You got a D.");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("You got an F.");
            letter = "F";
        }

        Console.WriteLine($"You got an {letter}.");

        if (percentage >= 60)
        {
            Console.WriteLine("Congratulations!!! You passed the course!!!");
        }
        else
        {
            Console.WriteLine("You failed the course, but Jesus still loves you, and you can try again next time.");
        }

    }
}