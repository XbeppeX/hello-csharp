using System;

namespace HelloCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mesi = { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" };
            Console.WriteLine("Benvenuti!");

            for (int i = 0; i < mesi.Length; i++)
            {
                Console.WriteLine(mesi[i]);
            }

            Console.Write("Qual'è il tuo mese preferito? ");
            string mese = Console.ReadLine();

            Console.WriteLine("Questo è il tuo mese preferito: " + mese);
            Console.WriteLine("Grazie!");


        }
    }
}
