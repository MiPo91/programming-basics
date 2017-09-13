using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give number!");

            string numberGiven = Console.ReadLine();
            int convertedNumber;
            int.TryParse(numberGiven, out convertedNumber);
            int even = 0;
            int odd = 0;

            if (convertedNumber > 0) { //positive
                for (int i = 1; i <= convertedNumber; i++)
                {
                    if (i % 2 == 0)
                    {
                        even = even + i;
                    }
                    else
                    {
                        odd = odd + i;
                    }

                }

                Console.WriteLine("Parittomien summa = {0}, Parillisten summa = {1}", odd, even);
            } else if(convertedNumber < 0) { // negative 
                for (int i = -1; i >= convertedNumber; i--)
                {
                    if (i % 2 == 0)
                    {
                        even = even - i;
                    }
                    else
                    {
                        odd = odd - i;
                    }

                }

                Console.WriteLine("Parittomien summa = -{0}, Parillisten summa = -{1}", odd, even);
            }
            else
            {
                Console.WriteLine("Määrittelemätön.");
            }

            Console.ReadKey();
        }
    }
}
