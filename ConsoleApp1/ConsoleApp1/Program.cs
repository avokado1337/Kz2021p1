using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the game to guess numbers.");

            Console.WriteLine("First player, please choose a number to guess and the number of allowed attempts.");
            var theNumber = ReadNumberFromConsole();
            Console.WriteLine("Number of allowed attempts: ");
            int attemptStart = 0;
            int attemptCount = ReadNumberFromConsole();
            Console.Clear();
            Console.WriteLine("Hi Second player.");
            int guessNumber;
            
            bool isWin = false;
            do
            {
                Console.WriteLine($"Try to guess the number. Your attempt #{++attemptStart}");

                guessNumber = ReadNumberFromConsole();
                if (guessNumber < theNumber)
                {

                    Console.WriteLine("you number LESS than The number");
                }
                else if (guessNumber > theNumber)
                {
                    Console.WriteLine("you number MORE than The number");
                }
                else
                {
                    isWin = true;
                }
            } while (guessNumber != theNumber && attemptStart < attemptCount);

            Console.WriteLine(isWin ? "You win" : "Lose!");
        }


        /// <summary>
        /// Request data from user while he enter a number
        /// </summary>
        /// <returns>Return a number which entered by user</returns>
        private static int ReadNumberFromConsole()
        {
            int theNumber;
            string str;
            do
            {
                Console.WriteLine("Enter the number: ");
                str = Console.ReadLine();
                //Console.WriteLine($"The line \"{str}\" not number. Enter the number: ");
            } while (!int.TryParse(str, out theNumber));

            return theNumber;
        }
    }
}
