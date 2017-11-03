using System;  //so we don't have to write "system" for System.Console.ReadLine();

namespace FitnessFrogConsoleApp
{
    class Program
    {
        static void Main()
        {
            double total = 0;

            while (true)
            {
                //prompt the user for minutes excercised
                Console.Write("Enter how many minutes you excercise or type 'quit': ");
                string entry = Console.ReadLine();

                //repeat until the user quits
                if (entry.ToLower() == "quit")
                {
                    break;
                } 
   
                //add minutes excercised to total
                try
                {
                    total += double.Parse(entry);

                    if (total <= 0)
                    {
                        Console.WriteLine("Invalid number:" + entry);
                        continue;
                    }
                    else if (total <= 10)
                    {
                        Console.WriteLine("Better than nothing.");
                    }
                    else if (total <= 30)
                    {
                        Console.WriteLine("Way to go.");
                    }
                    else
                    {
                        Console.WriteLine("Extreme!");
                    }

                    //display total minutes excercised to the screen
                    Console.WriteLine("You've entered a total of " + total + " minutes.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must be an integer or 'quit'!");
                }
            }

            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
