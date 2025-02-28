using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód. 
            int a;
            Console.Write("Podaj pierwszy bok prostokąta: ");
            a= Convert.ToInt32(Console.ReadLine());
            int b;
            Console.Write("Podaj drugi bok prostokąta: ");
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pole prostokąta wynosi={0}", a * b);
            Console.WriteLine("Obwód prostokąta wynosi={0}", a * 2+ b*2);
            Console.ReadKey(true);
        }
    }
}
