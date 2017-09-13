using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give number!");

            string input = Console.ReadLine();
            int usersNumber;
            int.TryParse(input, out usersNumber);

            string functionResults = calculateStars(usersNumber); // calling function for results
            Console.WriteLine(functionResults);

            Console.ReadKey();
        }

        public static string calculateStars(int usersNumber)
        {
            string result = "";
            if(usersNumber > 0) {
                for(int i = 0; i < usersNumber; i++) { // summing stars to variable through loop
                    result += "*";
                }
            } else {
                result = "Number " + usersNumber + " is not allowed number.";
            }

            return result;
        }
    }
}
