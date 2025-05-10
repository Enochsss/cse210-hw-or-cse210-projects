using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Type the magic number: ");
        // string input = Console.ReadLine();
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 111);
        int guess = 0;
        string input;
        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
    }
}