using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Napisać program wczytujący od użytkownika liczbę rzeczywistą x. Wczytuj tak długo wartość
            //zmiennej x, aż przyjmie ona wartość dodatnią. Wczytaną dodatnią wartość liczby x wypisz na
            //ekranie.Użyj pętli do -while.
            double x;
            do
            {
                Console.Write("Podaj liczbę rzeczywistą x (dodatnią): ");
                x = Convert.ToDouble(Console.ReadLine());
                if (x <= 0)
                {
                    Console.WriteLine("Liczba musi być dodatnia. Spróbuj ponownie.");
                }
            } while (x <= 0);
            Console.WriteLine("Wprowadzona dodatnia liczba x to: {0}", x);
            Console.ReadKey(true);
        }
    }
}
