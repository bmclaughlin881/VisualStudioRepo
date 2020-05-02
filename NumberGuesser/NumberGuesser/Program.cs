using System;
// Namespace
namespace NumberGuesser
{
    //MainClass
    class Program
    {
        // Entry point for the appliacation
        static void Main(string[] args)
        {
            // Set App Vars
            GetAppInfo(); // Call Get App Info
            GreetUser(); // Gets users name

           

            while (true)
            {

                Random random = new Random();
                int correct_number = random.Next(1, 10);
                int guess_number = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess_number != correct_number)
                {
                    // get user guess form console as strying
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess_number))
                    {
                        ChangeColour(ConsoleColor.Red, "Please use and actual number");
                        continue;
                    }
                    // cast to int and put into int
                    guess_number = Int32.Parse(input);

                    if (guess_number != correct_number)
                    {
                        ChangeColour(ConsoleColor.Red, "That Number is not correct try another!!");
                    }
                }

                // Output Success Message

                ChangeColour(ConsoleColor.Yellow, "Correct you guessed it!!");

                // Ask do they want to play again
                Console.WriteLine("Do you want to play again [Y] or [N]");

                String answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "Version 1.0.0";
            string appAuthor = "Brian McLaughlin";

            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Gray; 

            Console.WriteLine("{0} : {1} : {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("what is your name?");

            string inputname = Console.ReadLine();

            Console.WriteLine("Hello {0} lets play number guesser!", inputname);
        }

        static void ChangeColour(ConsoleColor colour, string message)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
 }   

