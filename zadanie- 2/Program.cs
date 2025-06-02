using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie__2
{
    internal class Program
    {
       
            //2. Napisz funkcję, która wyznacza n-ty wyraz ciągu Fibonacciego zadany przez argument
            //wywołania funkcji wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
            //Napisz program testowy wykorzystujący napisaną funkcję.
            //Wskazówka: Definicja rekurencyjna ciągu Fibonacciego:
            static long fib(long n)
            {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return fib(n - 1) + fib(n - 2);
            }
        static void Main(string[] args)
        {
            Console.Write("Podaj n= ");
            long n = Convert.ToInt64(Console.ReadLine());
            if (n < 0) Console.WriteLine("błędny argument");
            else Console.WriteLine("Fibonacci({0})={1}", n, fib(n));
            Console.ReadKey(true);
        }


    }
}
