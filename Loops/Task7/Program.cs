using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            Console.WriteLine("Multiplication table for numbers 1-9.");

            for(int i = 1; i < 10; i++) { // doing the calculation
                number = i * i;
                Console.WriteLine("{0} x {0} = {1}", i, number);
            }

            Console.ReadKey();
        }
    }
}
