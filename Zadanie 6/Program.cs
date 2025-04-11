﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        //6. Napisać procedurę (czyli funkcję, która nie zwraca żadnej wartości) posiadającą trzy
        //parametry: a-długość boku kwadratu, znak1-znak będący konturem kwadratu, znak2-znak
        //będący wypełnieniem kwadratu.Procedura ma rysować na ekranie kwadrat o zadanych
        //argumentach. Przetestuj działanie utworzonej procedury.

        static void kwadrat(int a, char znak1, char znak2)
        {
            int i, j;
            for(i=1; i<=a; i++) Console.Write(znak1);
            Console.WriteLine("");
            for(i=2;i<=a-1;i++)
            {
                Console.Write(znak1);
                for (j = 2; j <= a - 1; j++)
                {
                    Console.Write(znak2);
                }
                Console.WriteLine(znak1);
            }
        }
            
        
        static void Main(string[] args)
        {
            kwadrat(6, '#', '*');
            Console.ReadKey(true);
        }
    }
}
