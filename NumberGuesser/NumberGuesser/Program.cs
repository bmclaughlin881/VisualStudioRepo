using System;
// Namesace
namespace NumberGuesser
{
    //MainClass
    class Program
    {
        // Entry point for the appliacation
        static void Main(string[] args)
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "Version 1.0.0";
            string appAuthor = "Brian McLaughlin";

            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Gray; 

            Console.WriteLine("{0} : {1} : {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("what is your name?");

            string input = Console.ReadLine();

            Console.WriteLine("Hello {0} lets play number guesser!", input);

            int correct_number = 7;
            int guess_number = 0;

            Console.WriteLine("Guess a number between 1 and 10");



        }
    }
}
