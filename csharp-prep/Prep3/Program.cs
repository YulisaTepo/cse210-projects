using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guessing number game!");

        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int integerNumber = int.Parse(number);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int integerGuess = int.Parse(guess);
        while (integerGuess != integerNumber)
        { 
            if (integerGuess > integerNumber)
            {
            Console.WriteLine("Lower");
            }
            else if (integerGuess < integerNumber)
            {
            Console.WriteLine("Higher");
            }
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            integerGuess = int.Parse(guess); 
        }         
        Console.WriteLine("You guessed it!");

    }
    
}
