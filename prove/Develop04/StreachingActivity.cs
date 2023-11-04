public class StreachingActivity : Activity
{
    public StreachingActivity() : base(@"Streaching Activity", "This activity will help you stretch and relax the neck area. NOTE: Do the exercises gently and slowly.")
    {
    }
    
    private void DisplayIndications()
    {
        Console.WriteLine();
        Console.Write("Tilt your head toward your LEFT. "); DisplayCountdown(6);
        Console.WriteLine();
        Console.Write("Tilt your head toward your RIGHT. "); DisplayCountdown(6);
        Console.WriteLine();
        Console.Write("Tilt your head FORWARD. "); DisplayCountdown(6);
        Console.WriteLine();
        Console.Write("Tilt your head BACK. "); DisplayCountdown(6);
        Console.WriteLine();
        Console.Write("Tilt your head MAKING CIRCLES. "); DisplayCountdown(6);
        Console.WriteLine();
    }
    public void RunStreachingActivity()
    {
        StartingMessage();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayIndications();
            Console.WriteLine();
        }
        EndingMessage();
    }
}