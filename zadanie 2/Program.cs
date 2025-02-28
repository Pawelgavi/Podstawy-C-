using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero. 
            int a;
            Console.Write("podaj liczbę całkowitą: ");
            a=Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("liczba {0} jest dodatnia", a);
            else if (a < 0)
                Console.WriteLine("liczba {0} jest ujemna", a);
            else
                Console.WriteLine("liczba {0} jest równa 0",a);
            Console.ReadKey(true);
        }
    }
}
