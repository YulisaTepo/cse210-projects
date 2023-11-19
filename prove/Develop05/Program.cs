using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        PointsRedeemer pointsRedeemer = new PointsRedeemer();
        Console.WriteLine("--- Eternal Quest Program ---");
        int points = 0;
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {points} points");
            Console.WriteLine();
            Console.Write(@"Menu options:   
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Redeem points
    7. Quit
Select an option from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine(@"The type of goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create?");
                string goalType = Console.ReadLine();
                //SIMPLE GOAL
                if (goalType == "1")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string answer1 = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string answer2 = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string stringAnswer3 = Console.ReadLine();
                    int answer3 = Convert.ToInt32(stringAnswer3);
                    Simple simpleGoal = new Simple(answer1, answer2, answer3);
                    goals.Add(simpleGoal);
                }
                //ETERNAL GOAL
                else if (goalType == "2")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string answer1 = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string answer2 = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string stringAnswer3 = Console.ReadLine();
                    int answer3 = Convert.ToInt32(stringAnswer3);
                    Eternal eternalGoal = new Eternal(answer1, answer2, answer3);
                    goals.Add(eternalGoal);
                }
                //CHECKLIST GOAL
                else if (goalType == "3")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string answer1 = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string answer2 = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string stringAnswer3 = Console.ReadLine();
                    int answer3 = Convert.ToInt32(stringAnswer3);
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    string stringAnswer4 = Console.ReadLine();
                    int answer4 = Convert.ToInt32(stringAnswer4);
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    string stringAnswer5 = Console.ReadLine();
                    int answer5 = Convert.ToInt32(stringAnswer5);
                    Checklist checklistGoal = new Checklist(answer1, answer2, answer3, answer5, answer4);
                    goals.Add(checklistGoal);
                }
            }
            //LISTING GOALS
            else if (input == "2")
            {
                int counter1 = 1;
                foreach (Goal goal in goals)
                {

                    Console.WriteLine($"{counter1}. {goal.DisplayString()}");
                    counter1 = counter1 + 1;
                }
            }
            //SAVING GOALS
            else if (input == "3")
            {
                Console.WriteLine("What is the name of the filename? ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(points);
                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.ToSavedString());
                    }
                }
            }
            //LOADING GOALS
            else if (input == "4")
            {
                Console.WriteLine("What is the name for the goal file? ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                //This load the points
                points = int.Parse(lines[0]);
                goals.Clear();
                foreach (string line in lines.Skip(1))
                {
                    string[] parts = line.Split("|");
                    if (parts[0] == "Simple")
                    {
                        Simple simple = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        goals.Add(simple);
                    }
                    else if (parts[0] == "Eternal")
                    {
                        Eternal eternal = new Eternal(parts[1], parts[2], int.Parse(parts[3]));
                        goals.Add(eternal);
                    }
                    else if (parts[0] == "Checklist")
                    {
                        Checklist checklist = new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                        goals.Add(checklist);
                    }
                }
            }
            //RECORDING EVENT
            else if (input == "5")
            {
                Console.WriteLine("The Goals are: ");
                int counter2 = 1;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"{counter2}. {goal.GetName()}");
                    counter2 = counter2 + 1;
                }
                Console.WriteLine("Which goal did you accomplished? ");
                string accomplished = Console.ReadLine();
                int accomplishedIndex = int.Parse(accomplished);
                int pointsEarned = goals[accomplishedIndex - 1].RecordEvent();
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                points = points + pointsEarned;
                Console.WriteLine($"You now have {points} points");
            }
            //QUIT
            else if (input == "6")
            {
                Console.WriteLine(@"
You can redeem POINTS for INSPIRATIONAL QUOTES.
* Each quote worths 5 points.");
                Console.WriteLine();
                Console.WriteLine("Press enter to get your inspiritual quote: ");
                Console.ReadLine();
                if (points < 5)
                {
                    Console.WriteLine("You do not have enough points.");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return to menu: ");
                    Console.ReadLine();
                }
                else
                {
                    string quote = pointsRedeemer.GetRandomQuote();
                    Console.WriteLine(quote);
                    Console.WriteLine();
                    points = points - 5;
                    Console.WriteLine($"You now have {points} points");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return to menu: ");
                    Console.ReadLine();
                }
            }
            else if (input == "7")
            {
                break;
            }
        }
    }
}