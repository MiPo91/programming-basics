using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give string!");
            string userInput = Console.ReadLine();
      
            string toUpperStr = userInput.ToUpper(); // input to uppercase
            int stringLength = toUpperStr.Length; // string length for loop

            string character = "L";
            char[] stringArray = toUpperStr.ToCharArray(); // string to char array
            char[] characterArray = character.ToCharArray(); // character to char array for easy comparisong

            int characterCount = 0;

            for (int i=0;i < stringLength;i++) {
                if (stringArray[i] == characterArray[0]) { // comparing characters
                    characterCount++;
                }
            }

            Console.WriteLine("Input: {0}, Output: There is {1} L characters in {2}", userInput, characterCount, toUpperStr);
            Console.ReadKey();
        }
    }
}
