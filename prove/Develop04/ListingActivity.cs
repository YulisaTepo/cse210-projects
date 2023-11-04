public class ListingActivity : Activity
{
    private List<String> _promptList = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    Random random = new Random();
    private List<String> _userResponseList = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    private void CountMessage()
    {
        int countList = _userResponseList.Count();
        Console.WriteLine($"You listed {countList} items!");
    }

    private void DisplayListingPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        int index = random.Next(_promptList.Count());
        Console.WriteLine($" --- {_promptList[index]} ---");
        Console.WriteLine("You nay begin in: ");
        DisplayCountdown(5);
    }

    private void GetResponses()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _userResponseList.Add(Console.ReadLine());
        }
    }

    public void RunListingActivity()
    {
        StartingMessage();
        DisplayListingPrompt();
        GetResponses();
        CountMessage();
        Console.WriteLine();
        EndingMessage();
    }
}