public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.Date = DateTime.Now.ToString("MM/dd/yyyy");
        PromptGenerator promptGenerator = new PromptGenerator();
        entry.Prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"{entry.Prompt}");
        entry.EntryText = Console.ReadLine();
        _entries.Add(entry);
    }
    public void ViewEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void LoadEntries()
    {
        Console.WriteLine("Enter the filename to load entries from:");
        string filename = Console.ReadLine();
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry();
            entry.Date = parts[0];
            entry.Prompt = parts[1];
            entry.EntryText = parts[2];
            _entries.Add(entry);
        }
    }
    public void SaveEntries()
    {
        Console.WriteLine("Enter the filename to save entries to:");
        string filename = Console.ReadLine();
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            lines.Add($"{entry.Date}|{entry.Prompt}|{entry.EntryText}");
        }
        System.IO.File.WriteAllLines(filename, lines);
    }
}