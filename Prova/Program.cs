
using System;

namespace FunzioniMatematiche
{
    class Program
    {
        static void Main(string[] args)
        {
            int somma = Matematica.SommaInt(4, 7);
            Console.WriteLine($"somma {somma}");
            double moltiplicazione = Matematica.Moltiplicazione(6, 7);
            Console.WriteLine($"moltiplicazione {moltiplicazione}");
            double divisione = Matematica.Divisione(6, 3);
            Console.WriteLine($"divisione {divisione}");
            long fattoriale = Matematica.CalcoloFattoriale(5);
            Console.WriteLine($"Fattoriale {fattoriale}");
            long potenza = Matematica.Potenza(5, 5);
            Console.WriteLine($"Potenza {potenza}");
            bool IsPari = Matematica.IsDispari(4);
            Console.WriteLine($"ISPari {IsPari}");

        }
    }
}
