using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 1; i <= 13; i++) {
                double randomedNumber = rnd.NextDouble(); // generating random double number between 0 and 1
                randomedNumber = Math.Round(randomedNumber, 1); // rounding it up to single decimal

                if (randomedNumber <= 0.4) {
                    Console.WriteLine("1");
                }
                else if (randomedNumber > 0.4 && randomedNumber <= 0.6) {
                    Console.WriteLine("X");
                }
                else {
                    Console.WriteLine("2");
                }
            }

            Console.ReadKey();
        }
    }
}
