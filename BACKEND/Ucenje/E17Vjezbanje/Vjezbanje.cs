

using System;
using System.Text;

namespace Ucenje.E17Vjezbanje
{
    // Klasa za generiranje lozinki prema korisničkim pravilima
    internal class Vjezbanje
    {
        // Random objekt za generiranje slučajnih brojeva
        private static readonly Random rnd = new();

        // Glavna metoda koja traži unos podataka i generira lozinke
        public static void Pokreni()
        {
            // Traži od korisnika unos dužine lozinke
            Console.Write("Dužina lozinke: ");
            int duzina = int.Parse(Console.ReadLine()!);

            // Traži od korisnika želi li uključiti velika slova
            Console.Write("Uključiti velika slova (da/ne): ");
            bool velika = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika želi li uključiti mala slova
            Console.Write("Uključiti mala slova (da/ne): ");
            bool mala = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika želi li uključiti brojeve
            Console.Write("Uključiti brojeve (da/ne): ");
            bool brojevi = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika želi li uključiti interpunkcijske znakove
            Console.Write("Uključiti interpunkcijske znakove (da/ne): ");
            bool interpunkcija = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika treba li lozinka počinjati brojem
            Console.Write("Lozinka počinje brojem (da/ne): ");
            bool pocinjeBrojem = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika treba li lozinka počinjati interpunkcijskim znakom
            Console.Write("Lozinka počinje interpunkcijskim znakom (da/ne): ");
            bool pocinjeInterp = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika treba li lozinka završavati brojem
            Console.Write("Lozinka završava brojem (da/ne): ");
            bool zavrsavaBrojem = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika treba li lozinka završavati interpunkcijskim znakom
            Console.Write("Lozinka završava interpunkcijskim znakom (da/ne): ");
            bool zavrsavaInterp = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika smije li lozinka imati ponavljajuće znakove
            Console.Write("Lozinka ima ponavljajuće znakove (da/ne): ");
            bool ponavljanja = Console.ReadLine()!.Trim().ToLower() == "da";

            // Traži od korisnika koliko lozinki želi generirati
            Console.Write("Broj lozinki za generirati: ");
            int broj = int.Parse(Console.ReadLine()!);

            // Generira i ispisuje lozinke prema zadanim pravilima
            for (int i = 0; i < broj; i++)
            {
                string lozinka = GenerirajLozinku(
                    duzina, velika, mala, brojevi, interpunkcija,
                    pocinjeBrojem, pocinjeInterp, zavrsavaBrojem, zavrsavaInterp, ponavljanja
                );
                Console.WriteLine($"Lozinka {i + 1}: {lozinka}");
            }
        }

        // Metoda za generiranje lozinke prema zadanim pravilima
        private static string GenerirajLozinku(
            int duzina, bool velika, bool mala, bool brojevi, bool interpunkcija,
            bool pocinjeBrojem, bool pocinjeInterp, bool zavrsavaBrojem, bool zavrsavaInterp, bool ponavljanja)
        {
            // Definira skupove znakova
            string velikaSlova = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string malaSlova = "abcdefghijklmnopqrstuvwxyz";
            string brojke = "0123456789";
            string interp = "!@#$%^&*()_+-=,./<>?;:'[]{}|";

            // Sastavlja skup svih mogućih znakova prema odabiru korisnika
            StringBuilder skup = new();
            if (velika) skup.Append(velikaSlova);
            if (mala) skup.Append(malaSlova);
            if (brojevi) skup.Append(brojke);
            if (interpunkcija) skup.Append(interp);

            // Ako nije odabran nijedan skup, vraća praznu lozinku
            if (skup.Length == 0)
                return "";

            char[] lozinka = new char[duzina];

            // Postavlja prvi znak prema pravilima
            if (pocinjeBrojem)
                lozinka[0] = brojke[rnd.Next(brojke.Length)];
            else if (pocinjeInterp)
                lozinka[0] = interp[rnd.Next(interp.Length)];
            else
                lozinka[0] = skup[rnd.Next(skup.Length)];

            // Postavlja zadnji znak prema pravilima (ako lozinka ima više od jednog znaka)
            if (duzina > 1)
            {
                if (zavrsavaBrojem)
                    lozinka[duzina - 1] = brojke[rnd.Next(brojke.Length)];
                else if (zavrsavaInterp)
                    lozinka[duzina - 1] = interp[rnd.Next(interp.Length)];
                else
                    lozinka[duzina - 1] = skup[rnd.Next(skup.Length)];
            }

            // Popunjava sredinu lozinke prema pravilima i dopuštenju ponavljanja
            for (int i = 1; i < duzina - 1; i++)
            {
                char znak;
                do
                {
                    znak = skup[rnd.Next(skup.Length)];
                } while (!ponavljanja && Array.IndexOf(lozinka, znak) != -1);
                lozinka[i] = znak;
            }

            // Vraća generiranu lozinku kao string
            return new string(lozinka);
        }
    }
}