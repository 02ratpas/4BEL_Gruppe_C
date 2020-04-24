using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Umrechnung in verschiedene Zahlensysteme
// Gruppe C
namespace Fork_4BEL_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zahl_1 = 0;
            int Auswahl = 0;
            int Ergebnis = 0;



            Console.WriteLine("Wähle: 1 (Binär -> Dezimal) 2 (Binär -> Hexadezimal");
            Auswahl = Convert.ToInt16(Console.ReadLine());


            //Schrötter, zahleneingabe


            if (Auswahl == 1)
                Ergebnis = Dezimal(Zahl_1);

            if (Auswahl == 2)
                Ergebnis = Hexadezimal(Zahl_1);


            Console.WriteLine("Ergebnis = " + Ergebnis);
            Console.ReadKey();
        }



        static int Dezimal(int Zahl_1)
        {
            int Ergebnis = 0;

            //Pötti, Dezimal Rechnung

            return Ergebnis;
        }
        static int Hexadezimal(int Zahl_1)
        {
            int Ergebnis = 0;

            //Ratti, Hexa rechnung

            return Ergebnis;
        }
    }
}
