namespace Ucenje
{
    // Definira imenski prostor (namespace) koji grupira povezane klase
    internal class E01UlazIzlaz
    {
        // Definira javnu statičku metodu koja se može pozvati bez instanciranja klase
        public static void Izvedi()
        {
            // Ispisuje tekst "Pozdrav svijetu" bez prelaska u novi red
            Console.Write("Pozdrav svijetu");

            // Ispisuje tekst "Isti red" i prelazi u novi red
            Console.WriteLine("Isti red");

            // Ispisuje "Osijek je", zatim prelazi u novi red (\n), pa ispisuje "SUPER"
            Console.WriteLine("Osijek je\nSUPER");

            // Ispisuje tekst s dva tabulatora (\t\t) ispred, što stvara uvlačenje
            Console.WriteLine("\t\tOvo je uvučeno");

            // Ispisuje tekst "Unesi svoje ime:" bez prelaska u novi red
            Console.Write("Unesi svoje ime:");

            // Deklarira varijablu 'ime' tipa string? (može biti null) i dodjeljuje joj vrijednost koju korisnik unese
            string? ime = Console.ReadLine();

            // Ispisuje tekst "Unijeli ste" i vrijednost varijable 'ime' koristeći formatiranje
            Console.WriteLine("Unijeli ste {0}", ime);

        }

        // kraj metode

    } // kraj klase
} // kraj imenskog prostora (namespace)
