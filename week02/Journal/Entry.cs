public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string EntryText { get; set; }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine();
    }
}
