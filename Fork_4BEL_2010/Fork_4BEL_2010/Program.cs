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
            Int32 Zahl_1 = 0;
            int Auswahl = 0;
            Int32 Ergebnis = 0;



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

        //Umwandlung Binär in Dezimal
        static Int32 Dezimal(Int32 Zahl_1)
        {
            Int32 Ergebnis = 0;
            int Counter = 0;
            string StringZahl_1 = "";

            StringZahl_1 = Convert.ToString(Zahl_1);

            //Umwandlung
            for (int i = StringZahl_1.Length; i >= 0; i--)
            {
                if (StringZahl_1[i] == 1)
                {
                    Ergebnis = Convert.ToInt32(Math.Pow(2, Counter));
                }
                if (StringZahl_1[i] == 0)
                {}

                //Erhöhung Counter
                Counter++;
            }                    

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
