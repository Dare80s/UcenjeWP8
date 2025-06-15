namespace Ucenje
{
    internal class E09DoWhile
    {
        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("do-while petlja");

            // do-while petlja se izvršava barem jednom, bez obzira na uvjet
            // Sintaksa: do { ... } while (uvjet);

            int i = 0;

            // Primjer: Ispisuje brojeve od 0 do 4
            do
            {
                // Ispisuje trenutnu vrijednost varijable i
                Console.WriteLine(i);
                i++;
            } while (i < 5);

            Console.WriteLine("********************");

            // Primjer: Unos broja dok korisnik ne unese broj veći od 10
            int broj;
            do
            {
                Console.Write("Unesi broj veći od 10: ");
                broj = int.Parse(Console.ReadLine());
            } while (broj <= 10);

            Console.WriteLine("Unio si broj: " + broj);

            // do-while je koristan kada želimo da se tijelo petlje izvrši barem jednom
        }
    }
}
