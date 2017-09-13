using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give word!");
            string userInput = Console.ReadLine();
            string upperCase = userInput.ToUpper();

            
            char[] vowels = {'A', 'E', 'I', 'O', 'U', 'Y', 'Ä', 'Ö'}; // vowels to array
            int vowelsCount = 0;
            int wordLength = upperCase.Length;

            // checking if characters match in word with vowels array
            foreach(char vowel in vowels) {
                for(int i = 0; i < wordLength; i++) {
                    if(vowel == upperCase[i]) {
                        vowelsCount++;
                    }
                }
            }

            Console.WriteLine("Input: {0}, Output: Word {1} contains {2} vowels.", userInput, upperCase, vowelsCount);
            Console.ReadKey();
        }
    }
}