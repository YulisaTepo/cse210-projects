using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Activity
{
    private string _description;
    private string _name;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void StartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int duration = Convert.ToInt32(input);
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
    }

    protected void EndingMessage()
    {
        Console.WriteLine("Well done!");
        DisplaySpinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        DisplaySpinner();
    }

    protected void DisplayCountdown(int number)
    {
        for (int i = number; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void DisplaySpinner()
    {
        List<String> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        foreach (string line in spinner)
        {
            Console.Write(line);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }
    }
}
