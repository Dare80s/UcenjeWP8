namespace Ucenje
{
    internal class E03Operatori
    {
        // u Program.cs dodati E03Operatori.Izvedi();
        public static void Izvedi()
        {
            // početak
            Console.WriteLine("E03Operatori");

            // = dodjeljivanje vrijednosti s desne na lijevu stranu
            // Primjer: a = 5; (vrijednost 5 se dodjeljuje varijabli a)

            // neću objašnjavati + - / * matematički
            // Osnovni matematički operatori: + (zbrajanje), - (oduzimanje), * (množenje), / (dijeljenje)

            // + kao operator nadoljepljivanja (concate)
            // Kada se koristi s tekstom (string), + spaja tekstove

            string grad = "Osijek";
            string ime = "Edunova";

            // Spajanje stringova i broja u jedan tekstualni ispis
            Console.WriteLine(grad + " " + ime + " " + 5);// ovo nije najbolja praksa kod ispisa

            // Bolji način formatiranja ispisa s više vrijednosti
            Console.WriteLine("{0} {1} {2}", grad, ime, 5); // odrađuje isti posao kao gornja ali brže

            // operator modulo % -> vraća ostatak pri dijeljenju (koristi se za provjeru parnosti broja)
            Console.WriteLine(8 % 2); // 0 (8 je djeljivo s 2)

            int b = 9 % 2; // 1 (9 podijeljeno s 2 daje ostatak 1)

            Console.WriteLine(b);

            // uvećanje broja za 1
            int i = 0;

            // uvećaj za 1 na tri različita načina
            i = i + 1; // klasično povećanje za 1
            i += 1;    // skraćeni zapis za povećanje za 1
            i++;       // post-increment: prvo koristi pa poveća
            ++i;       // pre-increment: prvo poveća pa koristi

            // increment i decrement (++i, i++,  --i, i--);
            // ++ povećava vrijednost za 1, -- smanjuje vrijednost za 1

            int k = 1, j = 0;

            // Kombinacija pre-incrementa i post-incrementa
            k = ++k - j++; // ++k: k postaje 2, j++: j se koristi kao 0 pa postaje 1; k = 2 - 0 = 2

            // Kombinacija pre-decrementa i post-incrementa u izrazu
            Console.WriteLine(--k + j++); // --k: k postaje 1, j++: j se koristi kao 1 pa postaje 2; ispisuje 1 + 1 = 2

            // kraj
        }
    }
}
