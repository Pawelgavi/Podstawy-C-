using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Napisać program wczytujący współrzędne punktu P=(x,y) i wypisujący na ekranie informację,
            //do której ćwiartki ten punkt należy, czy też informację, że leży on na osi OX i/ lub osi OY.
            Console.Write("Podaj współrzędną x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Podaj współrzędną y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Punkt leży w I ćwiartce.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Punkt leży w II ćwiartce.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Punkt leży w III ćwiartce.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Punkt leży w IV ćwiartce.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Punkt leży na początku układu współrzędnych.");
            }
            else if (x == 0)
            {
                Console.WriteLine("Punkt leży na osi OY.");
            }
            else if (y == 0)
            {
                Console.WriteLine("Punkt leży na osi OX.");
            }

        }
    }
}
