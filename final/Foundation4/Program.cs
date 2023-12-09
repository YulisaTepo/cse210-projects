using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();
        Running running = new Running("07 Dic 2023", 30, 4.8);
        Cycling cycling = new Cycling("02 Jun 2023", 30, 9.6);
        Swimming swimming = new Swimming("12 Jan 2024", 8, 2);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}