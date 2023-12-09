using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new Lectures("Romeo and Juliet", "William Shakespeare Tragedy", "02/01/2024", "7:00PM", new Address("Daniel Alcides #123, Guadalupe, La libertad"), "Daniels Smith", 20);
        Reception reception = new Reception("Concert", "Official Carnival Party 2024 - Cajamarca", "10/02/2024", "5:00PM", new Address("Fongal Cajamarca, Av. Atahualpa, Inca Baths"), "register_here@gmail.com");
        Outdoor_Gathering outdoorGathering = new Outdoor_Gathering("Bingo", "Play bingo, a lot of awards waiting for you!", "15/01/2024", "3:00PM", new Address("Manuel Seoane #183, Guadalupe, La libertad"), "22°C, clear with cloudy intervals");
        Console.WriteLine("-------- LECTURE EVENT --------");
        Console.WriteLine(lectures.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(lectures.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lectures.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("-------- RECEPTION EVENT --------");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("-------- OUTDOOR GATHERING EVENTS --------");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
    }

}