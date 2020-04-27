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
            int Zahl_1 =0 ;
            int Zahl_2 = 0;
            int Auswahl = 0;
            int Ergebnis = 0;



            Console.WriteLine("Wähle: 1 (Binär -> Dezimal) 2 (Binär -> Hexadezimal");
            Auswahl = Convert.ToInt16(Console.ReadLine());


            //Schrötter, zahleneingabe


            if (Auswahl == 1)
                Ergebnis = Dezimal(Zahl_1, Zahl_2);

            if (Auswahl == 2)
            {
                String str_Ergebnis = Hexadezimal(Convert.ToString(Zahl_1));
                Console.WriteLine("Ergebnis Hexadezimal = " + str_Ergebnis);
            }


            Console.WriteLine("Ergebnis = " + Ergebnis);
            Console.ReadKey();
        }



        static int Dezimal(int Zahl_1, int Zahl_2)
        {
            int Ergebnis = 0;

            //Pötti, Dezimal Rechnung

            return Ergebnis;
        }
        static string Hexadezimal(string bi)
        {
            //Raphael-Hexa-Umrechner
            string Ergebnis="";
            string Nibbel="";
            for (int i = 0; i != bi.Length % 4; )
                bi=bi.Insert(0, "0");
            for (int i = 0; i < bi.Length; i++)
            {
                Nibbel += bi[i];
                if (Nibbel.Length == 4)
                {
                    Ergebnis+=Nibbel_Converter(Nibbel);
                    Nibbel = "";
                }
            }
                return Ergebnis;
        }
        static string Nibbel_Converter(string Nibbel)
        { 
            string Hexaziffer="";
            switch (Nibbel)
            { 
                case "0000":
                    Hexaziffer = "0";
                    break;
                case "0001":
                    Hexaziffer = "1";
                    break;
                case "0010":
                    Hexaziffer = "2";
                    break;
                case "0011":
                    Hexaziffer = "3";
                    break;
                case "0100":
                    Hexaziffer = "4";
                    break;
                case "0101":
                    Hexaziffer = "5";
                    break;
                case "0110":
                    Hexaziffer = "6";
                    break;
                case "0111":
                    Hexaziffer = "7";
                    break;
                case "1000":
                    Hexaziffer = "8";
                    break;
                case "1001":
                    Hexaziffer = "9";
                    break;
                case "1010":
                    Hexaziffer = "a";
                    break;
                case "1011":
                    Hexaziffer = "b";
                    break;
                case "1100":
                    Hexaziffer = "c";
                    break;
                case "1101":
                    Hexaziffer = "d";
                    break;
                case "1110":
                    Hexaziffer = "e";
                    break;
                case "1111":
                    Hexaziffer = "f";
                    break;
                default:
                    break;        
            }
            return Hexaziffer;
        }
    }
}
