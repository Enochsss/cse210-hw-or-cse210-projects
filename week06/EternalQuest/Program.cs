using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("\nMenu Options:\n");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoalDetails(); break;
                case "3": manager.SaveGoals(); break;
                case "4": manager.LoadGoals(); break;
                case "5": manager.RecordEvent(); break;
            }

            manager.DisplayPlayerInfo();
        }
    }
}
