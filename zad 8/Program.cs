using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8. Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata
            //przestępne od roku_początkowego do roku_końcowego włącznie. Użyj pętli for.
            int rok_początkowy, rok_końcowy;
            Console.Write("Podaj rok początkowy: ");
            rok_początkowy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj rok końcowy: ");
            rok_końcowy = Convert.ToInt32(Console.ReadLine());
            for (i = rok_początkowy; i <= rok_końcowy; i++)
            {
                // Sprawdzamy, czy rok jest przestępny
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(true);
        }
    }
}
