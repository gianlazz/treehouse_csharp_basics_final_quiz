using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Write("Enter the number of times to print \"Yay!\": ");
                string userEntry = Console.ReadLine();
                int x = 0;

                if(userEntry == "quit") {
                    keepGoing = false;
                    break;
                }

                try
                {
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