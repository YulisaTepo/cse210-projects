class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Your Journal Online ^^!");

        // Instance of the PromptGenerator class.
        PromptGenerator promptGenerator = new PromptGenerator();
        // Instance of the Entry class.
        Entry entry = new Entry();
        // Instance of the Journal class.
        Journal journal = new Journal();
        
        while (true) 
        {           
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            //Get the answer:
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("How many promts do you want to respond today?");
                string number = Console.ReadLine();
                int intNumberOfPrompts = Convert.ToInt32(number);
                for (int i = 0; i < intNumberOfPrompts; i++)
                {
                    string propmt = promptGenerator.GetPrompt();
                    Console.WriteLine(propmt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString();
                    entry = new Entry();

                    entry._prompt = propmt;
                    entry._answer = response;
                    entry._date = date;
                    journal.AddEntry(entry);
                }
                Console.WriteLine(@"
Great! You have responded the established prompts! You're awesome!");
                
            }
            else if (option == "2")
            {
                journal.DisplayEntries();
            }
            else if (option == "3")
            {
                Console.WriteLine("What is the filename?");
                string filemane = Console.ReadLine();
                Console.WriteLine(filemane);
                //Loading file.
                journal.LoadJournal("Journal.txt");
            }
            else if (option == "4")
            {
                Console.WriteLine("What is the filename?");
                string filemane = Console.ReadLine();
                // Saving file.
                journal.SaveToFile(filemane);
                Console.WriteLine("Your Journal is saved.");
            }
            else if (option == "5")
            {
                break;
            }

        }
        // Final message
        Console.WriteLine("Thank you for using Your Journal Online :).");
    }
}