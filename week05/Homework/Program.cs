using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Alice Johnson", "Biology");
        Console.WriteLine(assignment.GetSummary());
        
        MathAssignment mathAssignment = new MathAssignment("John Doe", "Algebra", "5.1", "1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "History", "The Industrial Revolution");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}