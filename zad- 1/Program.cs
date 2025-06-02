using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych (dodatnich i ujemnych) i
            //wypisujący wczytane liczby na ekranie

            int[] tablica = new int[1000];
            int i, n;
            Console.WriteLine("Podaj liczbę n (1 <= n <= 1000):");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę {0}:", i + 1);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Liczba {0}: {1}", i + 1, tablica[i]);
            }
            Console.ReadKey(true);
        }
    }
}
