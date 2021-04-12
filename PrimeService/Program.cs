using System;

namespace PrimeServices
{
    class Program
    {
        static bool ContinuePrompt()
        {
            string input;

            do
            {
                Console.Write("\nWould you like to find another prime? (y/n): ");
                input = Console.ReadLine().ToLower();

                if (input == "y") return true;

            } while (input != "n");

            return false;
        }

        static int GenerateInteger()
        {
            int index; 

            do
            {
                Console.Write("Which prime are you looking for? (enter an integer > 0): ");

            } while (!Int32.TryParse(Console.ReadLine(), out index) ||
                    index < 1);

            return index;
        }

        static void Run()
        {
            int index = GenerateInteger();
            int result = PrimeService.GetPrime(index);

            Console.WriteLine($"\nPrime #{index} is {result}");
        }

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Run();
                running = ContinuePrompt();
                Console.Clear();
            }

            Console.WriteLine(@"

               _____                                         _ 
              / ____|                                       | |
             | (___   __ _ _   _  ___  _ __   __ _ _ __ __ _| |
              \___ \ / _` | | | |/ _ \| '_ \ / _` | '__/ _` | |
              ____) | (_| | |_| | (_) | | | | (_| | | | (_| |_|
             |_____/ \__,_|\__, |\___/|_| |_|\__,_|_|  \__,_(_)
                            __/ |                              
                           |___/                               
            ");
                                                                   
        }
    }
}
