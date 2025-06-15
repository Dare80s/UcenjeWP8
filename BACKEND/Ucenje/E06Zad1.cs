namespace Ucenje
{
    internal class E06Zad1
    {
        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("E06Zad1");

            // Program unosi ocjene u školi (njih 7) i ispisuje sve ocjene te prosjek ocjena.

            int i = 0; // Brojač za unos ocjena
            int[] ocjene = new int[7]; // Deklaracija niza za pohranu 7 ocjena

            // Unos svake ocjene pojedinačno
            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            // Zbrajanje svih ocjena iz niza
            int suma = ocjene[0] + ocjene[1] + ocjene[2] + ocjene[3] + ocjene[4] + ocjene[5] + ocjene[6];

            // Ispis svih ocjena odvojenih zarezom
            Console.WriteLine(string.Join(", ", ocjene));

            // Izračun i ispis prosjeka ocjena (cast u double radi točnog rezultata)
            Console.WriteLine("Prosjek je: {0}", (double)suma / 7);
        }
    }
}
