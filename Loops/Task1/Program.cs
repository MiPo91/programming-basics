using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give number!");

            string numberGiven = Console.ReadLine();
            int convertedNumber;
            int.TryParse(numberGiven, out convertedNumber);
            int calculatedResult = 1;

            if(convertedNumber > 0)
            {
                for(int i = 1; i <= convertedNumber; i++)
                {
                    
                     calculatedResult = calculatedResult * i;
                    
                }

                Console.WriteLine(calculatedResult);
            } else
            {
                Console.WriteLine("Määrittelemätön.");
            }

            Console.ReadKey();

        }
    }
}
