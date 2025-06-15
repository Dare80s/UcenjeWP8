
namespace Ucenje
{
    internal class E06Nizovi
    {
        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("E06Nizovi");

            // Primjer deklaracije više varijabli za svaki mjesec (ne preporučuje se)
            int sijecanj, veljaca, ozujak /* ...*/ ;

            // Nizovi - jednodimenzionalni (Arrays, polja)
            // Definiraju se s uglatom zagradom []
            int[] temp = new int[12]; // deklaracija niza od 12 elemenata (za mjesece)

            // Svaki element niza ima indeks (počinje od 0) i vrijednost
            temp[0] = -1; // siječanj
            temp[1] = 1;  // veljača
            // ...
            // Zadnji element niza (prosinac)
            temp[temp.Length - 1] = 1;

            // Ispis reference na niz (ne ispisuje sadržaj niza)
            Console.WriteLine(temp);

            // Ispis svih vrijednosti niza kao string, odvojenih zarezom
            Console.WriteLine(string.Join(",", temp));

            // Ispis vrijednosti drugog elementa niza (veljača)
            Console.WriteLine(temp[1]);

            // Deklaracija i inicijalizacija niza stringova
            string[] gradovi = new string[3];

            gradovi[0] = "Osijek";
            gradovi[1] = "Zagreb";
            gradovi[2] = "Donji Miholjac";
            // gradovi[3] = "Josipovac"; // Greška: indeks izvan granica niza

            // zadatak: ispisati Donji Miholjac
            // Console.WriteLine(gradovi[2]);

            // string je niz znakova (char)
            string ime = "Edunova";

            // Ispisuje šesto slovo iz varijable ime (indeks 5, slovo 'v')
            Console.WriteLine(ime[5]);

            // Kraća sintaksa kreiranja niza s početnim vrijednostima
            double[] iznosi = { 2.3, 4.7, 1.2, 8.4 };

            // Dvodimenzionalni nizovi (matrica/tablica)
            int[,] tablica = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            // Ispisuje broj 6 iz tablice (drugi red, treći stupac)
            Console.WriteLine(tablica[1, 2]);

            // Zamjenjuje vrijednost 4 s 17 (drugi red, prvi stupac)
            tablica[1, 0] = 17;

            // Za ispis svih vrijednosti dvodimenzionalnog niza koriste se petlje

            // Trodimenzionalni niz (kocka)
            int[,,] kocka = new int[10, 10, 10]; // može pohraniti 1000 vrijednosti

            // Četverodimenzionalni niz - tesseract (rijetko se koristi)

            // Primjer deklaracije višedimenzionalnog niza (multiverse)
            int[,,,,,,,] multiverse;
        }
    }
}
