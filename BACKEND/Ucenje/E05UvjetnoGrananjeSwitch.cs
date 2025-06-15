namespace Ucenje
{
    internal class E05UvjetnoGrananjeSwitch
    {

        public static void Izvedi()
        {
            // Ispisuje naziv lekcije u konzolu
            Console.WriteLine("E05UvjetnoGrananjeSwitch");

            // switch radi s tipovima podataka: int, string, char i enum
            // Više informacija: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/statements#1383-the-switch-statement

            // Traži od korisnika unos ocjene
            Console.Write("Unesi ocjenu brojem: ");
            int broj = int.Parse(Console.ReadLine());

            // Klasični switch izraz
            // Ovisno o vrijednosti varijable 'broj', izvršava odgovarajući case blok
            switch (broj)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break; // prekida izvršavanje switch bloka
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo Dobar");
                    break;
                case 5:
                    Console.WriteLine("Izvrstan");
                    break;
                case 6:
                case 7:
                    // Više case-ova može imati isti blok koda
                    Console.WriteLine("Pa i to bi mogle biti ocjene ali nisu");
                    break;
                default:
                    // Izvršava se ako nijedan case nije zadovoljen
                    Console.WriteLine("nije ocjena");
                    break;
            }

            // Moderni switch izraz (expression)
            // Dodjeljuje tekstualni opis ocjene varijabli na temelju vrijednosti 'broj'
            string opisOcjene = broj switch
            {
                1 => "Nedovoljan",
                2 => "Dovoljan",
                3 => "Dobar",
                4 => "Vrlo Dobar",
                5 => "Izvrstan",
                6 or 7 => "Pa i to bi mogle biti ocjene ali nisu", // više vrijednosti u jednom izrazu
                _ => "Nije ocjena" // _ označava 'sve ostalo'
            };

            // Ispisuje rezultat modernog switch izraza
            Console.WriteLine(opisOcjene);
        }
    }
}
