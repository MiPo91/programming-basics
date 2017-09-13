using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give number!");

            string numberGiven = Console.ReadLine();
            int convertedNumber;
            int.TryParse(numberGiven, out convertedNumber);
            int calculatedResult = 0;

            if (convertedNumber > 0) { // calculating with positive numbers
                for (int i = 1; i <= convertedNumber; i++)
                {

                    calculatedResult = calculatedResult + i;

                }

                Console.WriteLine(calculatedResult);
            } else if(convertedNumber < 0) { // calculating with negative numbers
                for (int i = -1; i >= convertedNumber; i--)
                {
                    calculatedResult = calculatedResult - i;
                }

                Console.WriteLine("-"+calculatedResult);
            }
            else
            {
                Console.WriteLine("Määrittelemätön.");
            }

            Console.ReadKey();
        }
    }
}
