using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            //sumę wczytanych liczb.
            int[] tablica = new int[1000];
            int i, n, suma;
            Console.Write("Podaj liczbę n (1 <= n <= 1000):");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj liczbę {0}:", i);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (i = 0; i < n; i++)
            {
                suma += tablica[i];
            }
            Console.WriteLine("Suma wczytanych liczb wynosi: {0}", suma);
            Console.ReadKey(true);

        }
    }
}
