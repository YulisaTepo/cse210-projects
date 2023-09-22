using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        string result = DisplayResult(name, square);
        Console.WriteLine(result);
    }
    static void DisplayWelcome()
    {
    Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        

        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = Console.Read();
        return userNumber;            
    }
    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;            
    }
    static string DisplayResult(string userName, int square)
    {
        string result = $"{userName}, the square of your number is {square}.";
        return result;
    }
}