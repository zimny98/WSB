using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string str;
            int liczba;

            Console.WriteLine("Podaj liczbę całkowitą: ");
            str = Console.ReadLine();

            //liczba = int Parse(str);

            if (int.TryParse(str, out liczba) == false)
                Console.WriteLine("Zły format liczby");
            else
                Console.WriteLine("Liczba wynosi: {0}", liczba);

            /*
             * Sprawdź czy dane podane z klawiatury są liczbą dodatnią
             * następnie sprawdź czy jest nieparzysta
            */


            if (liczba > 0)
                Console.WriteLine("Podana liczba jest dodatnia");
            else
                Console.WriteLine("Podana liczba nie jest dodatnie");
            if (liczba % 2 != 0)
                Console.WriteLine("Podana liczba jest nieparzysta");
            else
                Console.WriteLine("Podana liczba nie jest parzysta");

            /* Użytkownik podaje dane dwóch boków
             * oblicz obwód i pole prostokąta
             * sprawdź czy dane z klawiatury zostały poprawnie wprowadzone
             * w przypadku błędnych danych wyświetl komunikat na ich temat
            */

            /*
            int a, b;
            Console.WriteLine("Podaj długość: ");
            a = Console.ReadLine();

            if (int.TryParse(str, out a) == false)
            Console.WriteLine("Zły format liczby");


            Console.WriteLine("Podaj szerokość: ");
            b = Console.ReadLine();

            if (int.TryParse(str, out b) == false)
                Console.WriteLine("Zły format liczby");


            if (a <= 0 || b <= 0)
                Console.WriteLine("Podałeś nieprawidłowe dane");
            else
                Console.WriteLine("")

            //if (int.TryParse(str, out a) == false)
              //  Console.WriteLine("Zły format liczby");
            */

            int age = 18;
            if (age == 18)
                Console.WriteLine("Masz 18 lat");
                else if (age < 18)
                    Console.WriteLine("Masz mniej niż 18 lat");
                    else
                        Console.WriteLine("Masz więcej niż 18 lat");
            //switch
            liczba = 10;
            switch (liczba)
            {
                case 5:
                    Console.WriteLine("Liczba = 5");
                    break;
                case 10:
                    Console.WriteLine("\nLiczba = 10");
                    break;
                case 15:
                    Console.WriteLine("\nLiczba = 15");
                    break;
                default:
                    Console.WriteLine("Liczba posiada inną wartość");
                    break;
            }

            /*
             * Użytkownik podaję narodowość
             * wykorzystaj instrukcję switch do wyświetlenia pochodzenia
             * polska, usa, hiszpania
            */

            Console.WriteLine("Podaj swoją narodowość: ");
            string narodowosc = Console.ReadLine();
            narodowosc = (narodowosc.ToLower());

            switch (narodowosc)
            {
                case "polak":
                    Console.WriteLine("Jesteś Polakiem");
                    break;
                case "usa":
                    Console.WriteLine("Jesteś Amerykaninem");
                    break;
                case "hiszpan":
                    Console.WriteLine("Jesteś Hiszpanem");
                    break;
                default:
                    Console.WriteLine("Jesteś innej narodowości");
                    break;
            }

            int i = 1;

            for (i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }



            Console.ReadKey();
        }
    }
}
