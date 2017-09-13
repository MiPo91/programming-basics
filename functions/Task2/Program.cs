using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // User inputs
            Console.WriteLine("Give first Number");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Give second Number");
            string userInput2 = Console.ReadLine();

            // Parsing to int
            int number1;
            int number2;
            int.TryParse(userInput1, out number1);
            int.TryParse(userInput2, out number2);

            // Calling function for results
            string functionResult = Minimi(number1, number2);

            // Displaying the results
            Console.WriteLine(functionResult);
            Console.ReadKey();
        }

        // Function to find smaller number
        public static string Minimi(int first, int second) {
            if(first < second) {
                return ""+first;
            } else if(first > second) {
                return ""+second;
            } else {
                return "numbers are equal";
            }
        }


       
    }
}
