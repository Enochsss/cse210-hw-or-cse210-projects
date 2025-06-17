using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2025, 3, 3), 30, 3.0),
            new Cycling(new DateTime(2025, 3, 11), 30, 9.7),
            new Swimming(new DateTime(2025, 3, 4), 30, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}