using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
                           
            GetAppInfo();  // Get and run app info

            GreetUser(); // Get user name and greet

            while (true) {

                // Initialized correct number and guess
                int correctNumber;
                int guess = 0;

                // Generate random number
                Random random = new Random();
                correctNumber = random.Next(1 , 10);

                Console.WriteLine("Guess a number between 1 and 10.");

                // 
                while (guess != correctNumber) {
                    // Get user's guess
                    string input = Console.ReadLine();

                    // Number validator
                    if (!int.TryParse(input, out guess) || input == "") {
                       // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number.");    
                        continue;
                    }

                    // Convert to number
                    guess = Convert.ToInt32(input);

                    // Wrong message with highlighting
                    if (guess != correctNumber) {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again."); 
                    }
                }

                // Correct message
                PrintColorMessage(ConsoleColor.Green, "CORRECT! Great job.");

                Console.WriteLine("Play again? {Y or N}");
                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y") {
                    continue;
                } else if (answer == "N") {
                    return;
                }
                else {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "John Ademoye";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}.", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
             // Get user name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine($"Hello, {inputName}. Let's play a game.");
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
