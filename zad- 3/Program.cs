using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
            //wypisujący posortowane liczby na ekranie.
            int[] tablica = new int[1000];
            int i, j;
            int n,tmp;
            Console.WriteLine("Podaj liczbę n (1 <= n <= 1000):");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę {0}:", i);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (tablica[i] > tablica[j])
                    {
                        tmp = tablica[i];
                        tablica[i] = tablica[j];
                        tablica[j] = tmp;
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Liczba {0}: {1}", i + 1, tablica[i]);
            }
            Console.ReadKey(true);

        }
    }
}
