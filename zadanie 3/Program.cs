using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb.
            double a, b, c;
            Console.Write("podaj pierwszą liczbę: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj drugą liczbę: ");
            b=Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj trzecią liczbę: ");
            c=Convert.ToDouble(Console.ReadLine());
            if ((a <= b) && (a <= c))
                Console.WriteLine("liczba {0} jest najmniejsza", a);
            else if ((b<=a)&&(b<=c))
                Console.WriteLine("liczba {0} jest najmniejsza", b);
            else
                Console.WriteLine("liczba {0} jest najmniejsza", c);
            if ((a >= b) && (a >= c))
                Console.WriteLine("liczba {0} jest największa", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("liczba {0} jest największa",b);
            else
                Console.WriteLine("liczba c jest największa",c);
            Console.ReadKey(true);
        }
    }
}
