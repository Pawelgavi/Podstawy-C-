using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z
            //przedziału[a, b].Użyj pętli while.
            int a, b, i;
            Console.Write("Podaj liczbe naturalną a:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe naturalną b:");
            b = Convert.ToInt32(Console.ReadLine());
            i=a;
            while (i <= b)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey(true);

        }
    }
}
