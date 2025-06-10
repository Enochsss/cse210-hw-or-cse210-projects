public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"List as many items as you can in response to the following prompt:\n{prompt}\n");
        Console.WriteLine($"You may begin in:");
        ShowCountdown(6);
        _count = 0;
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void GetListFromUser()
    {
        Console.WriteLine("Please enter your items (type 'done' to finish):");
        string input;
        while ((input = Console.ReadLine())?.ToLower() != "done")
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                _count++;
                Console.WriteLine($"Item added: {input}");
            }
            else
            {
                Console.WriteLine("Please enter a valid item or type 'done' to finish.");
            }
        }
        Console.WriteLine($"You listed {_count} items.");
    }
}