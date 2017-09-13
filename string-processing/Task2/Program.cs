using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give string!");
            string userInput = Console.ReadLine();
            string replacedText = userInput.Replace("e","@"); // replacing e with @

            Console.WriteLine("Input: {0}, Output: {1}", userInput, replacedText);
            Console.ReadKey();
        }
    }
}
