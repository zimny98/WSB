using System;


namespace _1a_first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imię: "); //wyświetli imię
            Console.WriteLine("Janusz");

            /*
             * komentarz
             * w
             * wielu
             * liniach
             */


            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "Anna";

            //konkatenacja
            Console.WriteLine("\nMasz na imię: "+name);

            Console.WriteLine("Masz na imię: {0}",name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0} wiek: {1}", name, age);

            sbyte age1 = 20;
            Console.WriteLine("Wiek: {0}", age1);

            /*
             * Użytkownik podaje z klawiatury długość boku.
             * Oblicz pole kwadratu
            */

            /*
            Console.WriteLine("\nPodaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("a = {0}", a);

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}",result);



            /*
             * Oblicz pole trójkąta
             * dane podaje użytkownik z klawiatury
            */

            Console.WriteLine("\nPodaj bok a:");
            string b = Console.ReadLine();
            Console.WriteLine("\nPodaj wysokość h:");
            string h = Console.ReadLine();

            double result2 = (double.Parse(b) * double.Parse(h))/2;
            Console.WriteLine("Pole trójkąta wynosi: {0}", result2);

            Console.ReadKey();
        }
    }
}
