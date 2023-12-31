public class ReflectionActivity : Activity
{
    private List<string> _promptList = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> _questionsList = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    Random random = new Random();

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    private void DisplayReflectionPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        int index = random.Next(_promptList.Count());
        Console.WriteLine($" --- {_promptList[index]} ---");
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadLine();
        
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You nay begin in: ");
        DisplayCountdown(5);
        Console.Clear();

    }
    private string GetQuestion()
    {
        int questionIndex = random.Next(_questionsList.Count());
        return _questionsList[questionIndex];
    }

    private void DisplayQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetQuestion()); DisplaySpinner();
        }
    }

    public void RunReflectionActivity()
    {
        StartingMessage();
        DisplayReflectionPrompt();
        DisplayQuestion();
        Console.WriteLine();
        EndingMessage();
    }
}