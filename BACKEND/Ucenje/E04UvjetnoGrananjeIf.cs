namespace Ucenje
{
    internal class E04UvjetnoGrananjeIf
    {

        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("E04UvjetnoGrananjeIf");

            // Deklaracija i inicijalizacija varijable tipa int
            int broj = 17; // Ovo je unio korisnik

            // operator ==   provjera jednakosti, rezultat je bool tip podatka
            // Provjerava je li broj jednak 7, rezultat je true ili false
            bool uvjet = broj == 7;

            // osnovna if sintaksa
            // if radi s bool tipom podatka
            if (uvjet)
            {
                // Ova linija će se ispisati samo ako je uvjet true
                Console.WriteLine("Super");
            }

            // if ne mora imati else
            // if ne mora imati {} ali kada ih nema odnosi se samo na prvu sljedeću liniju

            // puna sintaksa if naredbe
            // Provjerava više uvjeta redom
            if (broj > 2)
            {
                Console.WriteLine("OK");
            }
            else if (broj == 1)
            {
                Console.WriteLine("Nije dobro");
            }
            else
            {
                Console.WriteLine("NIJE OCJENA");
            }

            // operatori < >, >=, <=, != se koriste u if-u
            // Usporedni operatori za provjeru odnosa između vrijednosti

            // logički operatori: and, or i not
            // and
            // & (shift+6) - provjerava oba uvjeta bez obzira na prvi rezultat

            int i = 5, j = 10;

            // prvi uvjet ne prolazi ALI se drugi uvjet gleda
            if (i > 10 & j > 2)
            {
                // Ova linija se neće ispisati jer prvi uvjet nije zadovoljen
                Console.WriteLine("Neće se ispisati");
            }

            // INAČE KAKO SE KORISTI
            // && - ako prvi uvjet nije zadovoljen, drugi se ne provjerava
            if (i > 10 && j > 2)
            {
                Console.WriteLine("Neće se ispisati");
            }

            // or
            // | (altgr+w) - provjerava oba uvjeta
            // || - ako je prvi uvjet zadovoljen, drugi se ne provjerava
            if (i == 4 || j == 2)
            {
                Console.WriteLine("Jedno od dvoje");
            }

            // not 
            // ! - negira uvjet (true postaje false i obrnuto)
            if (!uvjet)
            {
                Console.WriteLine("Kada gore ne ispiše, ovdje će");
            }

            // Primjer ugniježđenih if naredbi
            string grad = "Osijek";

            if (uvjet && i > 10)
            {
                if (grad == "Vukovar")
                {
                    Console.WriteLine("Novi prvoligaš");
                }
            }

            // if-else grananje na temelju vrijednosti stringa
            if (grad == "Osijek")
            {
                Console.WriteLine("Super");
            }
            else
            {
                Console.WriteLine("OK");
            }

            // inline if (ternarni operator)
            // Ako je grad "Osijek" ispisuje "Super", inače "OK"
            Console.WriteLine(grad == "Osijek" ? "Super" : "OK");

        }

    }
}
