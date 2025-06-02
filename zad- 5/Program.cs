using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.

            int[] tablica = new int[100];
            int j, i = 0, n;
            Console.Write("Podaj liczbę naturalną n: ");
            n = Convert.ToInt32(Console.ReadLine());
            while ((n/2) != 0) || (n % 2 != 0) && (n%2!=0));
            {
                tablica[i] = n % 2;
                n = n / 2;
                i++;
            }
            for (j = i - 1; j >= 0; j--)
            {
                Console.Write(tablica[j]);
            }
            Console.ReadKey(true);
        }
    }
}
