namespace Ucenje
{
    internal class E11Z01
    {
        // Za učitani cijeli broj, program ispisuje da li je paran ili ne
        public static void Izvedi()
        {
            int b;
            // Beskonačna for petlja za unos broja dok unos nije ispravan
            for (; ; )
            {
                Console.WriteLine("Unesi cijeli broj: ");
                try
                {
                    // Pokušava parsirati unos korisnika u cijeli broj
                    b = int.Parse(Console.ReadLine());
                    break; // izlazi iz petlje ako je unos ispravan
                }
                catch
                {
                    // Ako unos nije cijeli broj, ispisuje poruku i traži ponovni unos
                    Console.WriteLine("Pokušajte ponovno.");
                }
            }
            // Provjerava je li uneseni broj paran (dijeljiv s 2 bez ostatka)
            if (b % 2 == 0)
            {
                Console.WriteLine("Uneseni broj {0} je paran", b);
            }
            else
            {
                Console.WriteLine("Uneseni broj {0} je neparan", b);
            }
        }
    }
}
