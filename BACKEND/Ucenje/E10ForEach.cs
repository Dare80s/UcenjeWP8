namespace Ucenje
{
    internal class E10ForEach
    {
        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("foreach");

            // Traži unos imena grada od korisnika
            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();

            // Ispisuje svako slovo grada jedno ispod drugog koristeći for petlju
            for (int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }

            Console.WriteLine("*****************************");

            // foreach petlja - jednostavniji način za prolazak kroz sve znakove stringa
            // Koristi se kada želimo proći kroz sve elemente kolekcije od početka do kraja
            foreach (char z in grad)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("*****************************");

            // Deklaracija i inicijalizacija niza cijelih brojeva
            int[] brojevi = { 1, 23, 3, 2, 2, 3, 4, 4, 5, 54, 4, 5, 5, 5, 565, 5, 56, 6, 5, 9 };

            // foreach petlja za ispis svakog broja iz niza
            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }
        }
    }
}
