namespace Ucenje
{
    internal class E12Metode
    {
        // metoda je organizacijska jedinica koda koja služi određenoj svrsi
        // cilj rada s metodama: Write once, use everywhere
        // static  - označava da se metoda može izvesti na klasi
        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("Metode");

            // Rad s metodama se sastoji od dva dijela:
            // 1. Tijelo metode (definicija)
            // 2. Poziv metode (korištenje)

            // Poziv metode tipa 1 (bez parametara i povratne vrijednosti)
            Tip1();
            for (int i = 0; i < 10; i++)
            {
                Tip1();
            }

            // Poziv metode tipa 2 (s jednim parametrom, bez povratne vrijednosti)
            Tip2(2);
            Tip2(7);

            // Poziv metode tipa 2 (overload s dva parametra)
            Tip2(2, 3); // po završetku metode nema povratne vrijednosti

            // Poziv metode tipa 3 (bez parametara, s povratnom vrijednosti)
            Tip3(); // povratna vrijednost nije iskorištena

            // Dodjeljivanje povratne vrijednosti metode tipa 3 varijabli
            string s = Tip3();
            Console.WriteLine(s);

            // Poziv metode tipa 4 (provjera je li broj prost)
            Console.WriteLine(prim(5));
            Console.WriteLine(prim(100000));

            // Ispis svih prostih brojeva od 1 do 100
            for (int i = 1; i <= 100; i++)
            {
                if (prim(i))
                {
                    Console.WriteLine(i);
                }
            }

            // Napiši program koji ispisuje zbroj dvaju brojeva
            Console.WriteLine(ucitajCijeliBroj("Unesi 1. broj") + ucitajCijeliBroj("Unesi 2. broj"));
        } // kraj metode Izvedi

        // Metoda tipa 1
        // Ne prima parametar i ne vraća vrijednost
        // Tijelo metode
        static void Tip1()
        {
            Console.WriteLine("Ispis iz metode tipa 1 koja je bez načina pristupa - vidljiva samo u klasi");
            Console.WriteLine("*******");
            Console.WriteLine("Edunova");
            Console.WriteLine("*******");
        }

        // Metoda tipa 2
        // Prima parametre, ne vraća vrijednost
        private static void Tip2(int i)
        {
            Console.WriteLine("Primio sam broj {0}", i);
        }

        // method overloading - ista metoda, različiti parametri
        private static void Tip2(int i, int j)
        {
            Console.WriteLine("Zbroj je {0}", i + j);
        }

        // Metoda tipa 3
        // Ne prima parametre, vraća vrijednost
        protected static string Tip3()
        {
            Console.WriteLine("Izvodim metodu tip3");
            return "Web programiranje";
        }

        // Metoda tipa 4
        // Prima parametre, vraća vrijednost
        // Provjerava je li primljeni broj prost (prime)
        public static bool prim(int broj)
        {
            // matematički princip hipoteze
            for (int i = 2; i < broj; i++)
            {
                // Ako je broj djeljiv s nekim brojem osim 1 i samog sebe, nije prost
                if (broj % i == 0)
                {
                    return false; // short circuiting - prekida metodu i petlju
                }
            }
            return true;
        }

        // Metoda za siguran unos cijelog broja s porukom
        public static int ucitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokušajte ponovo");
                }
            }
        }
    } // kraj klase
}
