using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? " );
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = ""; 
            if (percentage >= 90)
                letter = "A";
            else if (percentage >= 80)
                letter = "B";
            else if (percentage >= 70)
                letter = "C";
            else if (percentage >= 60)
                letter = "D"; 
            else if (percentage < 60)
                letter = "F";
            else
                Console.WriteLine("This is an invalid answer. Enter a valid number between 0-100.");             
                
        Console.WriteLine($"{letter}");
            
            if (percentage >= 70 && percentage <=100)
                Console.WriteLine("Congrats! You have passed the course!");
            else
                Console.WriteLine("You have not pass the course, your grade is less than 70. Do not give up, let's try it the next time :D. ");
            
        
    }
}