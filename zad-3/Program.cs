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
            //3. Dany jest trójkąt o współrzędnych A=(-4,-4), B=(4,-2), C=(6,6). Wczytaj od użytkownika
            //współrzędne punktu P = (x, y).Wypisz na ekranie informację czy punkt P leży wewnątrz, na
            //zewnątrz, czy też na boku trójkąta ABC.
            //Wskazówka: Wyznacz proste AB, AC i BC oraz sprawdź położenie punktu P względem
            //wyznaczonych prostych.
            Console.Write("Podaj współrzędną x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną y: ");
            double y = double.Parse(Console.ReadLine());
            double xA = -4, yA = -4;
            double xB = 4, yB = -2;
            double xC = 6, yC = 6;
            // Sprawdzenie położenia punktu P względem prostych AB, AC i BC
            double dAB = (yB - yA) * (x - xA) - (xB - xA) * (y - yA);
            double dAC = (yC - yA) * (x - xA) - (xC - xA) * (y - yA);
            double dBC = (yC - yB) * (x - xB) - (xC - xB) * (y - yB);
            if (dAB == 0 && dAC == 0 && dBC == 0)
            {
                Console.WriteLine("Punkt P leży na boku trójkąta ABC.");
            }
            else if ((dAB > 0 && dAC > 0 && dBC > 0) || (dAB < 0 && dAC < 0 && dBC < 0))
            {
                Console.WriteLine("Punkt P leży wewnątrz trójkąta ABC.");
            }
            else
            {
                Console.WriteLine("Punkt P leży na zewnątrz trójkąta ABC.");
            }
        }
    }
}
