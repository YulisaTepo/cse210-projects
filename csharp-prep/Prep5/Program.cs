using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        double square = SquareNumber(number);
        Console.WriteLine(square);
        string result = DisplayResult(name, square);
        Console.WriteLine(result);
    }
    static void DisplayWelcome()
    {
    Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        

        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = Console.Read();
        return userNumber;            
    }
    static double SquareNumber(int userNumber)
    {
        double square = Math.Sqrt(userNumber);
        return square;            
    }
    static string DisplayResult(string userName, double square)
    {
        string result = $"{userName}, the square of your number is {square}.";
        return result;
    }
}