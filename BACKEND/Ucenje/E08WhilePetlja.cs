namespace Ucenje
{
    internal class E08WhilePetlja
    {
        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("while petlja");

            // while radi s bool tipom podatka
            // Petlja se izvršava dok je uvjet true

            // Primjer beskonačne petlje
            while (true)
            {
                Console.WriteLine("Ispis iz beskonačne petlje nakon čega je break");
                break; // prekida beskonačnu petlju
            }

            Console.WriteLine("********************");

            // U while petlju se ne mora ući ako uvjet nije zadovoljen
            int i = 10;

            while (i < 10) // uvjet nije zadovoljen, tijelo se neće izvršiti
            {
                Console.WriteLine(i++);
            }

            Console.WriteLine("********************");

            // Primjer klasične while petlje
            i = 0; // resetira varijablu i
            while (i < 10)
            {
                Console.WriteLine(++i); // prvo poveća pa ispiše
            }

            Console.WriteLine("********************");

            // Korištenje više uvjeta u while petlji
            i = 0;
            int j = 1;
            while (i < 10 && j == 1) // može se koristiti i || (ili) te ! (not)
            {
                Console.WriteLine(i++);
            }

            Console.WriteLine("********************");

            // continue i break rade isto kao i u for petlji
            // Gnježđenje (ugnježđene petlje) je isto kao u for, može se kombinirati for i while

            // Primjer ugniježđene while petlje i korištenje goto za prekid vanjske petlje
            while (i > 10)
            {
                while (j == 1)
                {
                    // kako prekinuti petlju while (i > 10)?
                    goto labela; // izlazi iz obje petlje
                }
            }

        labela:
            Console.WriteLine("Gotov"); // ispis nakon izlaska iz petlje pomoću goto
        }
    }
}