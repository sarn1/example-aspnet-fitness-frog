using System;  //so we don't have to write "system" for System.Console.ReadLine();

namespace FitnessFrogConsoleApp
{
    class Program
    {
        static void Main()
        {
            int total = 0;
            bool keep_going = true;

            while (keep_going)
            {
                //prompt the user for minutes excercised
                Console.Write("Enter how many minutes you excercise or type 'quit': ");
                string entry = Console.ReadLine();

                //repeat until the user quits
                if (entry == "quit")
                {
                    keep_going = false;
                } else
                {
                    //add minutes excercised to total
                    total += int.Parse(entry);

                    //display total minutes excercised to the screen
                    Console.WriteLine("You've entered a total of " + total + " minutes.");
                }   
            }

            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
