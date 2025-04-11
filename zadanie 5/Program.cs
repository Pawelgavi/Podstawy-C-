using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    internal class Program
    {
        //5. Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
        //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
        //utworzonej funkcji.
        static int liczba_pierwsza (int liczba)
        {
            int i;
            for(i=2; i<liczba/2;i++)
                if (liczba%i==0) return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Czy liczba 21 jest pierwsza? {0}", liczba_pierwsza(21));
            Console.WriteLine("Czy liczba 23 jest pierwsza? {0}", liczba_pierwsza(23));
            Console.ReadKey(true);
        }
    }
}
