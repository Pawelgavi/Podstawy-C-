using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej największej z tych liczb. 
            double a, b, c, d, e,max,min;
            Console.Write("podaj pierwszą liczbę: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj drugą liczbę: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj trzecią liczbę: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj czwartą liczbę: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj piątą liczbę: ");
            e = Convert.ToDouble(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("liczba {0} jest najmniejsza", min);
            max = a;
            if(b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("liczba {0} jest największa", max);
            Console.ReadKey(true);



        }
    }
}
