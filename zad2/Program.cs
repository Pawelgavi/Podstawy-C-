using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n i
            //wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n).Użyj pętli while.
            int a, an, i;
            Console.Write("Podaj liczbę całkowitą dodatnią n: ");
            a = Convert.ToInt32(Console.ReadLine());
            i = 0;
            while(++i < a)
            {
                i++;
                an = 2 * i - 1;
                Console.WriteLine("a({0}) = {1}", i, an);
            }
            Console.ReadKey(true);
        }
    }
}
