

using Ucenje;
using Ucenje.E14KlasaObjekt; // Dodaj ovaj using za pristup klasi Automobil

internal partial class Program
{
    public static void Main(string[] args)
    {
        // Kreiranje novog objekta Automobil
        var auto = new Automobil
        {
            Sifra = 1,
            Marka = "Opel",
            Automatik = false,
            DatumProizvodnje = new DateTime(2020, 1, 1),
            Cijena = 15000m
        };

        // Ispis svojstava automobila
        Console.WriteLine($"Marka: {auto.Marka}, Cijena: {auto.Cijena}");
    }
}
