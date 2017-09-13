using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double neliojuuri = 0;
            for(int i = 1;i <= 10;i++)
            {
                neliojuuri = Math.Sqrt(i);
                neliojuuri = Math.Round(neliojuuri, 2);
                Console.WriteLine("Number {0} square root is {1}", i, neliojuuri);
            }

            Console.ReadKey();
        }
    }
}
