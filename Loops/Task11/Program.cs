using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int n6 = 0; // number of 6's counted

            for (int i = 1; i <= 1000; i++) {
                int dice = rnd.Next(1, 7);
                if (dice == 6) {
                    n6++;
                }
                Console.WriteLine("{0}. {1}", i, dice);
            }
            Console.WriteLine("Number six was randomed {0} number of times", n6);
            Console.ReadKey();
        }
    }
}
