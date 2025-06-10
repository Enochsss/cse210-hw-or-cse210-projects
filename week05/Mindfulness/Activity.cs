public abstract class Activity
{
    private string _activityName;
    private string _description;
    public int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _duration = 0; // Default duration
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(_activityName);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        while (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid number of seconds: ");
            input = Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine($"Great! Your {_activityName} will last for {_duration} seconds.");
        ShowSpinner(6);
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_activityName}.");
        Console.WriteLine("Thank you for participating!");
        ShowSpinner(6);
    }

    public void ShowSpinner(int duration)
    {
        Console.Write("Loading");
        for (int i = 0; i < duration; i++)
        {
            Console.Write("/");
            Thread.Sleep(900);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(900);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(900);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(900);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b");
        }
    }
    public abstract void Run();
}