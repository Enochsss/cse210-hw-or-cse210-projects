// my method HideRandomWords randomly hides a number of words in the scripture 
// text, but only if they are not already hidden.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, scriptureText);
        Random random = new Random();
        string userInput = "";
        while (!scripture.IsCompletelyHidden() && userInput.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide a word or type 'QUIT' to exit.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                int numberOfWordsToHide = random.Next(1, 4);
                scripture.HideRandomWords(numberOfWordsToHide);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nCongratulations! You've memorized the scripture.");
        }
        else
        {
            Console.WriteLine("\nGoodbye!");
        }
    }
}