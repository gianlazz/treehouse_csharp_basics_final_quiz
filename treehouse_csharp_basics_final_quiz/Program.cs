using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter the number of times to print \"Yay!\": ");
                string userEntry = Console.ReadLine();
                int x = 0;

                if(userEntry.ToLower() == "quit") {
                    break;
                }

                try
                {
                    if (int.Parse(userEntry) < 0)
                    {
                        Console.WriteLine("You must enter a positive number.");
                    }

                    while (x < int.Parse(userEntry))
                    {
                        Console.Write("Yay!");
                        x++;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a whole number.");
                    continue;
                }
            }
            Console.WriteLine("Code Execution Completed");
        }
    }
}