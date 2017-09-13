using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give number, it decides the coin toss count.");
            string usersNumber = Console.ReadLine();

            int convertedNumber;
            int.TryParse(usersNumber, out convertedNumber);

            // Setting up some variables used by loop
            int ctNumber = 0; // coin toss number
            int tails = 0;
            int heads = 0;

            Random rnd = new Random();
            for(int i = 1; i <= convertedNumber; i++) {
                ctNumber = rnd.Next(0, 2); // generating random number between 0 and 1
                if(ctNumber == 0) { // summing up the results for tails and heads
                    tails++;
                } else {
                    heads++;
                }
            }

            Console.WriteLine("Coin has been tossed {0} times", convertedNumber);
            Console.WriteLine("Tails {0} and Heads {1}", tails, heads);
            Console.ReadKey();
        }
    }
}
