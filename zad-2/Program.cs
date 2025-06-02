using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Napisać program wczytujący współrzędne dwóch punktów A=(x1,y1) i B=(x2,y2) oraz
            //wypisujący na ekranie wzór funkcji liniowej przechodzącej przez te dwa punkty.
            //Wskazówka: Równanie prostej przechodzącej przez dwa punkty:

            Console.Write("Podaj x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Podaj y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Podaj x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Podaj y2: ");
            double y2 = double.Parse(Console.ReadLine());

            if (x1 == x2)
            {

                Console.WriteLine($"Prosta pionowa: x = {x1}");
            }
            else
            {
                double a = (y2 - y1) / (x2 - x1);
                double b = y1 - a * x1;

                Console.WriteLine($"Równanie funkcji liniowej: y = {a}x + {b}");
            }

        }
    }
}
