using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej
            //odpowiednik rzymski
            int a;
            Console.Write("podaj liczbę arabską od 1 do 3999");
            a= Convert.ToInt32(Console.ReadLine());
            if (>=1000) { a -= 100;Console.Write"M"; }
            else if (>=2000) { a -= 100; Console.Write"MM"; }
            else if (>= 3000) { a -= 100; Console.Write"MMM"; }

            if (>=100) { a -= 100; Console.Write"C"; }
            else if (>= 200) { a -= 200; Console.Write"CC"; }
            else if (>= 300) { a -= 300; Console.Write"CCC"; }
            else if (>= 400) { a -= 400; Console.Write"CD"; }
            else if (>= 500) { a -= 500; Console.Write"D"; }
            else if (>= 600) { a -= 600; Console.Write"DC"; }
            else if (>= 700) { a -= 700; Console.Write"DCC"; }
            else if (>= 800) { a -= 800; Console.Write"DCCC"; }
            else if (>= 900) { a -= 900; Console.Write"CM"; }

            if (>=10) { a -= 10; Console.Write"X"; }
            else if (>=20) { a -= 20; Console.Write"XX"; }
            else if (>= 30) { a -= 30; Console.Write"XXX"; }
            else if (>= 40) { a -= 40; Console.Write"XL"; }
            else if (>= 50) { a -= 50; Console.Write"L"; }
            else if (>= 60) { a -= 60; Console.Write"LX"; }
            else if (>= 70) { a -= 70; Console.Write"LXX"; }
            else if (>= 80) { a -= 80; Console.Write"LXXX"; }
            else if (>= 90) { a -= 90; Console.Write"XC"; }

            switch (a)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("I"); break;
                case 3: Console.Write("I"); break;
                case 4: Console.Write("I"); break;
                case 5: Console.Write("I"); break;
                case 6: Console.Write("I"); break;
                case 7: Console.Write("I"); break;
                case 8: Console.Write("I"); break;
                case 9: Console.Write("I"); break;
                default: Console.Write(""); break;
            }
            Console.ReadKey(true);
        }
    }
}
