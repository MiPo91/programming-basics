using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.WriteLine("Please enter a number");

            // Read user input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input
            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            if(evaluatedNumber % 2 == 0)
            {
                Console.WriteLine("Number {0} is even.", evaluatedNumber);
            } else
            {
                Console.WriteLine("Number {0} is odd.", evaluatedNumber);
            }

            Console.ReadKey();

        }
    }
}
