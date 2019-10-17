using System;
namespace pole_prostokata
{
    class program
    {
        static void Main(String[] args)
        {

            /* Użytkownik podaje z klawiatury dane dwóch boków
             * Oblicz pole prostokąta i obwód
             *
             * Wyświetl w formacie:
             * Pole prostokąta wynosi...
             * Obwód prostokąta wynosi...
             *
             * Sprawdź czy dane z klawiatury są poprawne
             * W przypadku błędnych danych wyświetl komunikat: "Podałeś błędne dane"
             */

            float a1;
            float b1;

            Console.WriteLine("Podaj bok a prostokąta");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj bok b prostokąta");
            string b = Console.ReadLine();


            if (float.TryParse(a, out a1) == false) //sprawdzenie czy zmienna a jest liczbą
            {
                Console.WriteLine("Podałeś błędne dane");
            }
            else if (float.TryParse(b, out b1) == false) //sprawdzenie czy zmienna b jest liczbą
            {
                Console.WriteLine("Podałeś błędne dane");
            }
            else if (a1 < 0 || b1 < 0) //czy podana długość boków jest prawidłowa (większa od 0)
            {
                Console.WriteLine("Podałeś błędne dane");
            }

            else
            {
                float pole = a1 * b1; //obliczanie pola prostokąta
                float obw = (2 * a1) + (2 * b1); //obliczanie obwodu prostokąta

                Console.WriteLine("Pole prostokąta o bokach {0} i {1} wynosi {2}.\n" +
                    "Jego obwód to {3}.", a1, b1, pole, obw);
            }

            Console.ReadKey();
        }
    }
}
