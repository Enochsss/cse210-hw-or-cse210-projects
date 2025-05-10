using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();
        int numberSum = 0;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
            numberSum += number;

        }

        Console.WriteLine($"The sum is: {numberSum}");
        Console.WriteLine($"The average is: {(double)numberSum / (numbers.Count)}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}