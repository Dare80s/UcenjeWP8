namespace Ucenje
{
    internal class E07ForPetlja
    {
        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("E07ForPetlja");

            // for petlja se koristi za ponavljanje bloka koda određeni broj puta
            // Sintaksa: for (inicijalizacija; uvjet; inkrement/dekrement) { ... }

            // Primjer: Ispis brojeva od 1 do 10
            for (int i = 1; i <= 10; i++)
            {
                // Ispisuje trenutnu vrijednost varijable i
                Console.WriteLine(i);
            }

            // Primjer: Ispis parnih brojeva od 2 do 20
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            // Primjer: Ispis brojeva od 10 do 1 (unatrag)
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            // for petlja se često koristi za prolazak kroz elemente niza
            int[] brojevi = { 3, 5, 7, 9 };

            for (int i = 0; i < brojevi.Length; i++)
            {
                // Ispisuje svaki element niza brojevi
                Console.WriteLine(brojevi[i]);
            }
        }
    }
}
