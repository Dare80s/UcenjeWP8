

namespace Ucenje
{
    internal class E13Rekurzija
    {
        public static void Izvedi()
        {
            // Primjer rekurzije: izračun zbroja brojeva od 1 do 100
            // Poziva rekurzivnu metodu zbroj i ispisuje rezultat
            Console.WriteLine(zbroj(100));
        }

        // Rekurzivna metoda za izračun zbroja svih brojeva od 1 do i
        private static int zbroj(int i)
        {
            // Uvjet prekida rekurzije (baza rekurzije)
            if (i == 1)
            {
                return 1;
            }
            // Rekurzivni poziv: zbroj trenutnog broja i zbroja svih prethodnih
            return i + zbroj(i - 1);
        }
    }
}