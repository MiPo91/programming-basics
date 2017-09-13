using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listing 20 random numbers between numbers 0 - 50");
            int randomNumber;
            Random rnd = new Random();
            for (int i = 1; i <= 20; i++) // Looping 1-20
            {
                randomNumber =  rnd.Next(0, 50); // Generating random number between 0 and 50
                Console.WriteLine("Random number {0} = {1}", i, randomNumber);
            }
            Console.ReadKey();
        }
    }
}
