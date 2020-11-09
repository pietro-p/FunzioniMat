
using System;

namespace FunzioniMatematiche
{
    class Program
    {
        static void Main(string[] args)
        {
            long fattoriale = Matematica.CalcoloFattoriale(5);
            Console.WriteLine($"Fattoriale {fattoriale}");
            long potenza = Matematica.Potenza(5, 5);
            Console.WriteLine($"Potenza {potenza}");
            bool IsPari = Matematica.IsDispari(4);
            Console.WriteLine($"ISPari {IsPari}");

        }
    }
}
