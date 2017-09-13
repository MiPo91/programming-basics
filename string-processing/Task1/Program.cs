using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give string!");
            string userInput = Console.ReadLine();
            int strLength = userInput.Length; // getting length of sring

            Console.WriteLine("Your inputted string has {0} characters", strLength);
            Console.ReadKey();
        }
    }
}
