


namespace Ucenje.E14KlasaObjekt
{ // Klasa je opisnik objekta -> naučiti napamet
    // Glavna klasa programa
    internal class Program
    {
        // Konstruktor klase Program (naziv mora biti isti kao naziv klase)
        public Program()
        {
            // Ispisuje tekst prilikom kreiranja instance klase Program
            Console.WriteLine("Klasa/objekt");

            // Objekt je instanca klase
            // Osoba (veliko slovo O) je klasa, osoba (malo slovo o) je objekt
            Osoba osoba = new Osoba(); // Stvara novi objekt klase Osoba (poziva se konstruktor)

            // Postavljanje vrijednosti za svojstva objekta
            osoba.Sifra = 1; // Postavlja vrijednost svojstva Sifra
            // osoba.Ime = "Pero"; // Ova linija je zakomentirana, Ime ostaje null
            osoba.Prezime = "Perić"; // Postavlja prezime
            osoba.DatumRodenja = new DateTime(1980, 12, 7); // Postavlja datum rođenja

            // Primjer unosa vrijednosti od korisnika (zakomentirano)
            // osoba.Sifra = Pomocno.UcitajCijeliBroj("Unesi šifru osobe");
            // osoba.Prezime = Pomocno.UcitajString("Unesi prezime osobe");
            // osoba.DatumRodenja = new DateTime(
            //     Pomocno.UcitajCijeliBroj("Unesi godinu rođenja"),
            //     Pomocno.UcitajCijeliBroj("Unesi mjesec rođenja"),
            //     Pomocno.UcitajCijeliBroj("Unesi dan rođenja")
            // );

            // Korištenje vrijednosti svojstava
            Console.WriteLine(osoba.Prezime); // Ispisuje prezime
            Console.WriteLine(osoba.Ime); // Ispisuje ime (ako je null, ispisuje prazan string)
            Console.WriteLine(osoba.Ime ?? "nije postavljeno"); // Ako je ime null, ispisuje "nije postavljeno"

            // Poziv ne-statične metode objekta
            osoba.IspisiImeIPrezime();

            // osoba.Primjer(); // Ne može se pozvati statična metoda s objekta (zakomentirano)

            Osoba.Primjer(); // Statičnu metodu pozivamo s klase

            // Osoba.IspisiImeIPrezime(); // Ne može se pozvati ne-statična metoda s klase (zakomentirano)

            // Deklaracija niza objekata tipa Osoba
            Osoba[] osobe = new Osoba[3];

            // Skraćeni oblik postavljanja vrijednosti svojstava prilikom kreiranja objekta
            osobe[0] = new Osoba()
            {
                Ime = "Marija",
                Prezime = "Kat",
                Sifra = 2,
                DatumRodenja = new DateTime(1982, 1, 2)
            };

            // Inicijalizacija objekta s minimalnim podacima
            osobe[1] = new Osoba() { Ime = "Ante" };

            // Treći element niza postaje prethodno kreirani objekt osoba
            osobe[2] = osoba;

            // foreach petlja za ispis imena svih osoba u nizu
            foreach (Osoba o in osobe)
            {
                Console.WriteLine(o.Ime);
            }
        }

        // Ulazna točka programa
        public static void Izvedi()
        {
            // Kreira se instanca klase Program, što automatski poziva konstruktor
            new Program();
        }
    }

    // Definicija klase Osoba
    public class Osoba
    {
        // Svojstva klase Osoba
        public int Sifra { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }

        // Metoda za ispis imena i prezimena
        public void IspisiImeIPrezime()
        {
            Console.WriteLine($"{Ime} {Prezime}");
        }

        // Statična metoda primjer
        public static void Primjer()
        {
            Console.WriteLine("Ovo je statična metoda klase Osoba.");
        }
    }
}
