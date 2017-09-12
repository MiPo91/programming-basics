using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.WriteLine("Please enter 3 different number");

            
            int[] numberList = new int[3];
            
            // Saving user inputs to Array
            for(int i = 0; i < 3;i++)
            {
                string userInput;
                userInput = Console.ReadLine();
                
                int.TryParse(userInput, out numberList[i]);
            }
            
            // Sorting numbers
            Array.Sort(numberList);

            // Writing results to console
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numberList[i]);
            }

            Console.ReadKey();

        }
    }
}
