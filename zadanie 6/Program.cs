using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz.
            double a, b, suma, różnica, iloczyn, iloraz;
            Console.Write("podaj liczbę a: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj liczbę b: ");
            b= Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            różnica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("suma wynosi={0} ", suma);
            Console.WriteLine("różnica wynosi={0}", różnica);
            Console.WriteLine("iloczyn wynosi={0}", iloczyn);
            Console.WriteLine("iloraz wynosi={0},", iloraz);
            Console.ReadKey(true);

        }
    }
}
