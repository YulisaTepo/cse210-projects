public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    private void DisplayFirstBreathingMessages()
    {
        Console.WriteLine();
        Console.Write("Breathe in... "); DisplayCountdown(2);
        Console.WriteLine();
        Console.Write("Now breathe out... "); DisplayCountdown(3);
        Console.WriteLine();
    }

    private void DisplayBreathIngMessages()
    {
        Console.Write("Breathe in... "); DisplayCountdown(4);
        Console.WriteLine();
    }
    private void DisplayBreathOutgMessages()
    {
        Console.Write("Now breathe out... "); DisplayCountdown(6);
        Console.WriteLine();
    }

    public void RunBreathingActivity()
    {
        StartingMessage();
        DisplayFirstBreathingMessages();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration - 5);
        while (DateTime.Now < endTime)
        {
            DisplayBreathIngMessages();
            DisplayBreathOutgMessages();
            Console.WriteLine();
        }
        EndingMessage();
    }
}