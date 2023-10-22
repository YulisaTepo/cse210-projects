using System;

class Program
{
    static void Main(string[] args)
    {
        //Excceding requirements:
        // I created a While loop inside the Scripture class in the HideWords() method that hide the words that are not already hidden. 
        Reference _reference = new Reference("Proverbs", "3", "5", "6");
        string fullScripture = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(_reference, fullScripture);
        string option;
        do
        {
            Console.Clear();
            scripture.DisplayRenderedText();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish.");
            option = Console.ReadLine();

            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }
            else 
            {
                scripture.HideWords();
            }
        } while (option != "quit");
    }
}