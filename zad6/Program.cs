using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6. Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.
            //Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,
            //dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, które
            //pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0(zero).

            int wybor;
            do
            {
                Console.WriteLine("Wybierz figurę do obliczenia pola:");
                Console.WriteLine("1 - Pole prostokąta");
                Console.WriteLine("2 - Pole kwadratu");
                Console.WriteLine("3 - Pole trójkąta");
                Console.WriteLine("0 - Zakończ program");
                Console.Write("Twój wybór: ");
                wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        Console.Write("Podaj długość boku a prostokąta: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość boku b prostokąta: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole prostokąta wynosi: {0}", a * b);
                        break;
                    case 2:
                        Console.Write("Podaj długość boku kwadratu: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu wynosi: {0}", c * c);
                        break;
                    case 3:
                        Console.Write("Podaj podstawę trójkąta: ");
                        double podstawa = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj wysokość trójkąta: ");
                        double wysokosc = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole trójkąta wynosi: {0}", 0.5 * podstawa * wysokosc);
                        break;
                    case 0:
                        Console.WriteLine("Zakończenie programu.");
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
            } while (wybor != 0);
        }
    }
}
