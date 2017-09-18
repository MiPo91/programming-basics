using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Auto
    {
        public string merkki;
        public double nopeus;

        public Auto()
        {
            merkki = "Ford";
            nopeus = 80;
        }

        public Auto(string Merkki, double Nopeus)
        {
            merkki = Merkki;
            nopeus = Nopeus;
        }

        public string naytaTiedot()
        {
            Console.WriteLine("Merkki: {0}", merkki);
            Console.WriteLine("Nopeus: {0} km/h", nopeus);
            return merkki;
        }

        public double kiihdyta(double Nopeus)
        {
            nopeus = nopeus + Nopeus;

            return nopeus;
        }


        public double jarruta()
        {
            nopeus = nopeus * 0.9;

            return nopeus;
        }
    }
}
