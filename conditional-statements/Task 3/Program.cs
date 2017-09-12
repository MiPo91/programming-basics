using System;

namespace Task_3
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

            // Task 1
            string stateResult;
            if(evaluatedNumber > 0)
            {
                stateResult = "is positive";
            } else if(evaluatedNumber < 0)
            {
                stateResult = "is negative";
            } else
            {
                stateResult = "equals 0";
            }

            // Task 2
            string oddEvenResult;
            if (evaluatedNumber % 2 == 0)
            {
                oddEvenResult = "is even";
            }
            else
            {
                oddEvenResult = "is odd";
            }

            Console.WriteLine("Number {0} {1} and {2}.", evaluatedNumber, stateResult, oddEvenResult);

            Console.ReadKey();
        }
    }
}
