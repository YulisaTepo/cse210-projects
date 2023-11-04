using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();
        StreachingActivity streachingActivity = new StreachingActivity();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start streaching activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            //Get the answer:
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                breathingActivity.RunBreathingActivity();
                Console.Clear();
            }
            else if (option == "2")
            {
                Console.Clear();
                reflectionActivity.RunReflectionActivity();
                Console.Clear();
            }
            else if (option == "3")
            {
                Console.Clear();
                listingActivity.RunListingActivity();
            }
            else if (option == "4")
            {
                Console.Clear();
                streachingActivity.RunStreachingActivity();
            }
            else if (option == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("INVALID OPTION.");
            }
        }
    }
}