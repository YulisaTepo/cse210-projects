using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        List<int> numbers = new List<int>();
        
        //int number = -1;

        while (true)
        {
            
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number == 0)
                break;
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        } 
            {
                int sum = 0;
                int len = numbers.Count;
                int average = 0;
                int largest = 0; 
                foreach (int item in numbers)
                {
                    sum = sum + item;
                    average = sum / len;
                    if (item > largest)
                    {
                        largest = item;
                    }
                }
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The largest number is: {largest}");

                
            }


    }
}