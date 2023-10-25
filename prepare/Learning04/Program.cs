using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        //Base class
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        //Math class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", 7.3, "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        //Writing class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of Wold War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}