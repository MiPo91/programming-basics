using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generating up and down limit for numbers
            Random rng = new Random();
            int downLimit = rng.Next(1, 15);
            int upLimit = rng.Next(15, 30);

            Console.WriteLine("Give number between {0} and {1}", downLimit, upLimit);

            // Calling function for result
            int usersNumber = pyyda_luku_valilta(downLimit, upLimit);

            Console.WriteLine("Users given number is {0}",usersNumber);
            Console.ReadKey();

        }

        public static int pyyda_luku_valilta(int downlimit, int uplimit)
        {
            int usersNumber;

            while (true) // looping indefinetly until IF is true
            {
                string userInput = Console.ReadLine(); // users input
                int.TryParse(userInput, out usersNumber);

                if (usersNumber >= downlimit && usersNumber <= uplimit) { // Checking that input is between the values
                    break;
                } else {
                    Console.WriteLine("Give number between {0} and {1}", downlimit, uplimit);
                }
            }

            return usersNumber;

        }
    }
}
