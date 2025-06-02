using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytane
            //liczby w odwrotnej kolejności na ekranie.
            int[] tablica = new int[1000];
            int i, n;
            Console.WriteLine("Podaj liczbę n :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę {0}:", i + 1);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Liczby w odwrotnej kolejności:");
            for (i = n - 1; i >= 0; i--)
            {
                Console.WriteLine("Liczba {0}: {1}", n - i, tablica[i]);
            }
            Console.ReadKey(true);
        }
    }
}
