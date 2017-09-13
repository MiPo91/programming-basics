using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give string!");
            string userInput = Console.ReadLine().Replace(" ",""); //replace white space for word comparisong
            string upperCase = userInput.ToUpper();

            int arraySize = upperCase.Length - 1;

            string wordBackwards = "";
            
            // turning word backwards
            for(int i = arraySize; i >= 0; i--) {
                wordBackwards += upperCase[i];
            }

            if(upperCase == wordBackwards) {
                Console.WriteLine("Input: {0}, Output: {1} on palintromi.", userInput, upperCase);
            } else {
                Console.WriteLine("Input: {0}, Output: {1} ei ole palintromi.", userInput, upperCase);
            }
            Console.ReadKey();
        }
    }
}
