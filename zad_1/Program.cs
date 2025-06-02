using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Wczytaj od użytkownika liczbę naturalną n (n>2). Wpisz do pliku C:\tmp\wynik1.txt wartość
            //sumy 1 +…+n.Zakładamy, że plik C:\tmp\wynik1.txt nie istnieje.

            int i, n, suma = 0;
            Console.Write("podaj n=");
            n=convert.toint32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                suma += i;
            }
            string sciezka = @"C:\tmp\wynik1.txt";
            FileStream plik = new FileStream(sciezka, FileMode.Create, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(plik, Encoding.UTF8);
            writer.WriteLine(suma);
            writer.Close();
            plik.Close();
            Console.ReadKey(true);


        }
    }
}
