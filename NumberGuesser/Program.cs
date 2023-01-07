// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            //set correct number
            //int correctnumber = 7;

            while (true)
            {

                //generate random number
                Random r = new Random();

                int correctnumber = r.Next(1, 10);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctnumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep going
                        continue;
                    }

                    guess = Int32.Parse(input);

                    //match guess to correct Number 
                    if (guess != correctnumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again");
                    }

                }

                //Correct Guess
                PrintColorMessage(ConsoleColor.Yellow, "\"Congratulations , you guessed the correct number!!!");


                Console.WriteLine("Play again? [Y or N]");

                //get answer

                string ans = Console.ReadLine().ToUpper();

                if(ans == "N")
                {
                    break;
                }
                else if(ans == "Y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

        }
        public static void GetAppInfo() {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dhaval Desai";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        public static void GreetUser()
        {
            //Ask User Name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} , let's play a Game", inputName);
        }
        public static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
