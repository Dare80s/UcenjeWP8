namespace Ucenje
{
    internal class E11TryCatch
    {
        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("Try Catch");

            int b = 0;

            /*
            // Osnovni primjer try-catch bloka
            // try blok se uvijek izvodi
            try
            {
                // Pokušava parsirati unos korisnika u cijeli broj
                b = int.Parse(Console.ReadLine());

                // Ako dođe do iznimke, prelazi u catch blok
            }
            catch
            {
                // Ovdje se obrađuje iznimka (npr. korisnik nije unio broj)
                Console.WriteLine("Niste unijeli broj");
            }
            Console.WriteLine(b+1);
            */

            // Primjer: siguran unos broja s ponavljanjem dok unos nije ispravan
            while (true)
            {
                try
                {
                    Console.Write("Unesi broj: ");
                    b = int.Parse(Console.ReadLine());
                    break; // izlazi iz petlje ako je unos ispravan
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }

            // Ispisuje uneseni broj uvećan za 1
            Console.WriteLine(b + 1);

            // Program koji za dva unesena cijela broja ispisuje njihov zbroj
            int pb, db;

            // Unos prvog broja s provjerom
            while (true)
            {
                Console.Write("Unesi prvi broj: ");
                try
                {
                    pb = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli prvi broj");
                }
            }

            // Unos drugog broja s provjerom
            while (true)
            {
                Console.Write("Unesi drugi broj: ");
                try
                {
                    db = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli drugi broj!");
                }
            }

            // Ispisuje rezultat zbrajanja dva unesena broja
            Console.WriteLine("Rezultat {0} + {1} = {2}", pb, db, pb + db);

            // Dodatna provjera unosa broja s ograničenjem duljine i vrijednosti
            string unosniNizZnakova;
            while (true)
            {
                Console.Write("Unesi broj: ");
                unosniNizZnakova = Console.ReadLine().Trim();

                // Provjerava je li unos predugačak
                if (unosniNizZnakova.Length > 9)
                {
                    Console.WriteLine("Unijeli ste predugačak niz znakova");
                    continue;
                }
                // Siguran unos broja
                try
                {
                    b = int.Parse(unosniNizZnakova);
                    // Provjerava je li broj prevelik
                    if (b > 10000)
                    {
                        Console.WriteLine("Uneseni broj je preveliki, unesite manji broj");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unije broj!");
                }
            }

            // Ispisuje konačno uneseni broj
            Console.WriteLine("Unesen je broj {0}", b);

            // Nije dana puna sintaksa try-catch, ostalo nakon OOP-a
        }
    }
}