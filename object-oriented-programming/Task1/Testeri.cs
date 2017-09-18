using System;

namespace Task1
{
    class Testeri
    {
        static void Main(string[] args)
        {
            var auto1 = new Auto("BMW", 120);
            auto1.kiihdyta(40);
            auto1.jarruta();
            auto1.naytaTiedot();

            var auto2 = new Auto("Audi", 100);
            auto2.jarruta();
            auto2.naytaTiedot();

            var auto3 = new Auto("Nissan", 90);
            auto3.naytaTiedot();


            Console.ReadKey();
        }
    }
}
