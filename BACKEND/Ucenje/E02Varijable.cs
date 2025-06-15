namespace Ucenje
{

    // Definira imenski prostor (namespace) koji grupira povezane klase
    internal class E02Varijable
    {
        // Definira internu klasu dostupnu unutar iste asemblije
        public static void Izvedi()
        {
            // Definira javnu statičku metodu koja se može pozvati bez instanciranja klase

            // Ispisuje poruku korisniku bez prelaska u novi red
            Console.Write("Unesi svoje ime: ");


            // Deklaracija varijable tipa string za pohranu imena
            string ime;

            // Dodjeljuje vrijednost varijabli 'ime' na temelju korisničkog unosa
            ime = Console.ReadLine();

            // Ispisuje sadržaj varijable 'ime' u konzolu
            Console.WriteLine(ime);

            // Ispisuje prvi znak unesenog imena (indeks 0)
            Console.WriteLine(ime[0]); // 1. znak unesenog imena

            // Ispisuje zadnji znak unesenog imena (^1 označava zadnji element niza)
            Console.WriteLine(ime[^1]); // ^je znak koji se dobije s ALT GR + 3 - zadnji znak

            // string je niz znakova i prvi znak u tom nizu se nalazi na indeksu 0

            // Deklaracija i inicijalizacija varijable tipa char
            char znak = '@'; // char se piše u jednostrukim navodnicima i sadrži jedan znak

            // Ispisuje vrijednost varijable 'znak'
            Console.WriteLine(znak);

            // Ispisuje ASCII vrijednost znaka '@' (castanje u int)
            Console.WriteLine((int)znak); // (int) je cast 

            // Deklaracija i inicijalizacija varijable tipa int s najvećom mogućom vrijednosti
            int cijeliBroj = int.MaxValue;

            // Ispisuje najveću moguću vrijednost tipa int
            Console.WriteLine(int.MaxValue);

            // Ispisuje rezultat zbrajanja najveće vrijednosti int i 1 (dolazi do overflowa)
            Console.WriteLine(cijeliBroj + 1);

            // Ispisuje poruku korisniku za unos broja cipela
            Console.Write("Unesi broj cipela: ");

            // Parsira korisnički unos u cijeli broj i sprema ga u varijablu
            int brojCipela = int.Parse(Console.ReadLine());

            // Ispisuje broj cipela uvećan za 1
            Console.WriteLine(brojCipela + 1);

            // Deklaracija i inicijalizacija logičke varijable (bool)
            bool logickiTip = true; // druga vrijednost je false

            // Deklaracija i inicijalizacija varijabli s decimalnim vrijednostima
            float decimalniBroj = 3.14f; // float zahtijeva sufiks 'f'
            double velikiDecimalniBroj = 3.14; // double je zadani tip za decimalne brojeve
            decimal db = 3.14M; // decimal zahtijeva sufiks 'M'

            // slijedi kraj metode, piši iznad ovog komentara
        }

    }
}

