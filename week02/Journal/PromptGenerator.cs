public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What did I learn today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}