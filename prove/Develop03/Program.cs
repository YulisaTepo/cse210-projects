using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference _reference = new Reference("Proverbs", "3", "5", "6");
        //Word _word = new Word();        
        string fullScripture = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(_reference, fullScripture);
        //Console.WriteLine("Press enter to continue or type quit to finish.");
        string option;// = Console.ReadLine();
        do
        {
            Console.Clear();
            scripture.DisplayRenderedText();
            //Excced requirments: Compare the scripture the user types vs the correct scripture.
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish.");
            option = Console.ReadLine();

            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }
        //    else if (challenge == fullScripture)
        //    {
        //        Console.WriteLine("Congrat's you remorized the verse of the scripture!");
        //    }
            else //if (option == "")
            {
                scripture.HideWords();
                //scripture.DisplayRenderedText();
            }
        } while (option != "quit");
        //2 ways to quit.
        //if the user types quit.
        //If SCRIPTURE IS COMPLETE HIDDEN, QUIT, IF NOT CONTINUE HIDEN WORDS.
    }
}