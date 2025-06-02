using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy
            //1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for.
            int n, i, suma = 0;
            Console.Write("Podaj liczbę całkowitą n (n>2): ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                suma += i;
            Console.WriteLine("Suma liczb od 1 do {0} wynosi: {1}", n, suma);
            Console.ReadKey(true);
        }
    }
}
