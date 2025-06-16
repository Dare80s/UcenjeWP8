

namespace Ucenje
{
    internal class E001Zad
    {
        // Program "Test ljubavi" prema pravilima s fotografije
        public static void Izvedi()
        {
            // 1. Unos imena korisnika i simpatije
            Console.Write("Unesi svoje ime: ");
            string ime1 = Console.ReadLine().Trim().ToUpper();

            Console.Write("Unesi ime simpatije: ");
            string ime2 = Console.ReadLine().Trim().ToUpper();

            // 2. Za svako slovo imena, izračunaj koliko se puta pojavljuje u imenu
            int[] brojevi1 = new int[ime1.Length];
            for (int i = 0; i < ime1.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < ime1.Length; j++)
                {
                    if (ime1[i] == ime1[j])
                        count++;
                }
                brojevi1[i] = count;
            }

            int[] brojevi2 = new int[ime2.Length];
            for (int i = 0; i < ime2.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < ime2.Length; j++)
                {
                    if (ime2[i] == ime2[j])
                        count++;
                }
                brojevi2[i] = count;
            }

            // 3. Ispis imena i brojeva ispod svakog slova
            Console.WriteLine(ime1);
            foreach (var b in brojevi1)
                Console.Write(b);
            Console.WriteLine();

            Console.WriteLine(ime2);
            foreach (var b in brojevi2)
                Console.Write(b);
            Console.WriteLine();

            // 4. Kombiniraj brojeve: prvi broj ispod imena + zadnji broj ispod simpatije, drugi + predzadnji, itd.
            int duljina = Math.Max(brojevi1.Length, brojevi2.Length);
            int[] kombinacija = new int[duljina];
            for (int i = 0; i < duljina; i++)
            {
                int prvi = i < brojevi1.Length ? brojevi1[i] : 0;
                int zadnji = (duljina - 1 - i) < brojevi2.Length ? brojevi2[duljina - 1 - i] : 0;
                kombinacija[i] = prvi + zadnji;
            }

            // Ispis kombiniranog retka brojeva
            foreach (var b in kombinacija)
                Console.Write(b);
            Console.WriteLine();

            // 5. Smanjuj redak zbrajanjem susjednih brojeva dok ne ostanu samo dvije znamenke
            int[] trenutni = kombinacija;
            while (trenutni.Length > 2)
            {
                int[] novi = new int[trenutni.Length - 1];
                for (int i = 0; i < novi.Length; i++)
                {
                    novi[i] = trenutni[i] + trenutni[i + 1];
                    // Ako je rezultat dvoznamenkast, zbroji znamenke
                    if (novi[i] > 9)
                        novi[i] = (novi[i] / 10) + (novi[i] % 10);
                }
                trenutni = novi;
                foreach (var b in trenutni)
                    Console.Write(b);
                Console.WriteLine();
            }

            // 6. Rezultat: postotak šanse za ljubav
            int postotak = trenutni[0] * 10 + trenutni[1];
            Console.WriteLine($"Šansa za ljubav: {postotak}%");
        }
    }
}