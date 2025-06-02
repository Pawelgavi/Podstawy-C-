using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    struct Uczen
    {
        public string imie,nazwisko;
        public byte[] oceny;
    }
    class Program
        static void Main(string[] args)
        {
            //2. Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
            //Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
            //umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
            //Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.

            Uczen[] uczniowie;
            int liczbaUczniow, ile_ocen, i,j;
            Console.WriteLine("Podaj liczbę uczniów:");
            liczbaUczniow = Convert.ToInt32(Console.ReadLine());
            uczniowie = new Uczen[liczbaUczniow];
            for (i = 0; i < liczbaUczniow; i++)
            {
                Console.WriteLine("Podaj imię ucznia {0}:", i + 1);
                uczniowie[i].imie = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko ucznia {0}:", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.WriteLine("Podaj liczbę ocen dla ucznia {0}:", i + 1);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                uczniowie[i].oceny = new byte[ile_ocen];
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.WriteLine("Podaj ocenę {0} dla ucznia {1}:", j + 1, i + 1);
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine();
            }

        }   
}
