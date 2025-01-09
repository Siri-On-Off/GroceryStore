using System;

namespace Grocerystore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen des Artikelstamms und Hinzufügen der Artikel
            Artikelstamm artikelstamm = new Artikelstamm();
            artikelstamm.AddArtikel();

            // Erstellen des Verkaufsobjekts
            Verkauf verkauf = new Verkauf(99999, true, artikelstamm);

            // Hinzufügen von Positionen zum Verkauf
            verkauf.AddPosition(23242526, 2);  // Cola
            verkauf.AddPosition(25262728, 1);  // Lager
            verkauf.AddPosition(23456, 100);   // Gurke

            // Drucken der Rechnung
            verkauf.PrintRechnung();

            // Überprüfen, ob eine Artikelnummer gültig ist
            Console.WriteLine(artikelstamm.IsValidArtikelnummer(23456));
        }
    }
}