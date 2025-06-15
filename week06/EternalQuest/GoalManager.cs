using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score = 0;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created or loaded. Please create or load goals first.");
            return;
        }

        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is the description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(shortName, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(shortName, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus points for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames();

        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= goals.Count)
        {
            Goal goal = goals[index - 1];

            if (goal is SimpleGoal simpleGoal)
            {
                if (!simpleGoal.IsComplete())
                {
                    simpleGoal.RecordEvent();
                    AddPoints(simpleGoal.Points);
                    Console.WriteLine("Event recorded.");
                }
                else
                {
                    Console.WriteLine("This Simple Goal is already complete and cannot be recorded again for points.");
                }
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                if (!checklistGoal.IsComplete())
                {
                    checklistGoal.RecordEvent();
                    AddPoints(checklistGoal.Points);

                    if (checklistGoal.IsComplete())
                    {
                        AddPoints(checklistGoal.Bonus);
                        Console.WriteLine($"Congratulations! You completed the checklist goal and earned a bonus of {checklistGoal.Bonus} points.");
                    }
                    Console.WriteLine("Event recorded.");
                }
                else
                {
                    Console.WriteLine("This Checklist Goal is already complete and cannot be recorded again for points.");
                }
            }
            else if (goal is EternalGoal eternalGoal)
            {
                eternalGoal.RecordEvent();
                AddPoints(eternalGoal.Points);
                Console.WriteLine("Event recorded.");
            }
            else
            {
                Console.WriteLine("Invalid goal type.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine($"Score:{_score}");
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        goals.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line = reader.ReadLine();
            if (line.StartsWith("Score:"))
            {
                _score = int.Parse(line.Substring(6));
            }

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                string shortName = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);

                switch (type)
                {
                    case "SimpleGoal":
                        bool isCompleted = data[3] == "1";
                        var simpleGoal = new SimpleGoal(shortName, description, points);
                        if (isCompleted)
                            simpleGoal.RecordEvent();
                        goals.Add(simpleGoal);
                        break;

                    case "EternalGoal":
                        goals.Add(new EternalGoal(shortName, description, points));
                        break;

                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(data[3]);
                        int target = int.Parse(data[4]);
                        int bonus = int.Parse(data[5]);
                        var checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus)
                        {
                            AmountCompleted = amountCompleted
                        };
                        goals.Add(checklistGoal);
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded.");
    }

    public void AddPoints(int points)
    {
        _score += points;
    }
}