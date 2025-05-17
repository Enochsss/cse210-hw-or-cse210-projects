using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Journal journal = new Journal();

        while (choice != "5")
        {
            choice = ShowMenu();
            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.ViewEntries();
                    break;
                case "3":
                    journal.LoadEntries();
                    break;
                case "4":
                    journal.SaveEntries();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }
    static string ShowMenu()
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("");
            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. View journal entries");
            Console.WriteLine("3. Load journal entries");
            Console.WriteLine("4. Save journal entries");
            Console.WriteLine("5. Exit");
            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            return Console.ReadLine();
        }    
}