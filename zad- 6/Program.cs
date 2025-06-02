using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6. Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
            //foreach.
            string[] dniTygodnia = new string[] { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            foreach (string dzien in dniTygodnia)
            {
                Console.WriteLine(dzien);
            }
            Console.ReadKey(true);
        }
    }
}
