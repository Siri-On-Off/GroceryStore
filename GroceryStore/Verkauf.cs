using System;

using GroceryStore;

namespace Grocerystore
{
    public class Verkauf
    {
        private int auftragsnummer;
        private bool isRechnung;
        private Dictionary<int, int> positionen = new Dictionary<int, int>();
        private Artikelstamm art;

        public Verkauf(int auftragsnummer, bool isRechnung, Artikelstamm art)
        {
            this.auftragsnummer = auftragsnummer;
            this.isRechnung = isRechnung;
            this.art = art;
        }

        public void AddPosition(int artikelnummer, int menge)
        {
            if (art.IsValidArtikelnummer(artikelnummer))
            {
                positionen[artikelnummer] = menge;
                BestandsAenderung(artikelnummer, menge);
            }
            else
            {
                Console.WriteLine($"Artikelnummer {artikelnummer} ist ungültig.");
            }

            Console.WriteLine("Positionen nach dem Hinzufügen: ");
            foreach (var position in positionen)
            {
                Console.WriteLine($"Artikelnummer: {position.Key}, Menge: {position.Value}");
            }
            Console.WriteLine();
        }
        
        public void BestandsAenderung(int artikelnummer, int menge)
        {
            foreach (var artikel in art.ArtikelstammList)
            {
                if (artikel.Artikelnummer == artikelnummer)
                {
                    if (isRechnung)
                    {
                        artikel.ReduziereBestand(menge);
                        break;
                    }
                    else
                    {
                        artikel.AddiereBestand(menge);
                        break;
                    }
                }
            }
        }

        public void PrintRechnung()
        {
            if (isRechnung)
        {
            Console.WriteLine($"Rechnung Nr. {auftragsnummer}");
            Console.WriteLine("--------------------------------------------------");
            double gesamtbetrag = 0;

            foreach (var position in positionen)
            {
                int artikelnummer = position.Key;
                int menge = position.Value;
                Artikel artikel = art.GetArtikelByArtikelnummer(artikelnummer);
                
                if (artikel != null)
                {
                    double einzelpreis = artikel.Preis;
                    double gesamtpreis = einzelpreis * menge;
                    gesamtbetrag += gesamtpreis;

                    Console.WriteLine($"Artikel: {artikel.Bezeichnung}");
                    Console.WriteLine($"Artikelnummer: {artikel.Artikelnummer}");
                    Console.WriteLine($"Menge: {menge}");
                    Console.WriteLine($"Einzelpreis: {einzelpreis:C}");
                    Console.WriteLine($"Gesamtpreis: {gesamtpreis:C}");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine($"Gesamtbetrag: {gesamtbetrag:C}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(isRechnung ? "Rechnung abgeschlossen." : "Bestellung abgeschlossen.\n");
        }
            else
            {
                PrintRetour();
            }
        
        
        }
        private void PrintRetour()
        {
            Console.WriteLine($"Retoure Nr. {auftragsnummer}");
            Console.WriteLine("--------------------------------------------------");
            double gesamtbetrag = 0;

            foreach (var position in positionen)
            {
                int artikelnummer = position.Key;
                int menge = position.Value;
                Artikel artikel = art.GetArtikelByArtikelnummer(artikelnummer);

                if (artikel != null)
                {
                    double einzelpreis = artikel.Preis;
                    double gesamtpreis = einzelpreis * menge;
                    gesamtbetrag += gesamtpreis;

                    // Drucke die Artikelinformationen für die Retoure
                    Console.WriteLine($"Artikel: {artikel.Bezeichnung}");
                    Console.WriteLine($"Artikelnummer: {artikel.Artikelnummer}");
                    Console.WriteLine($"Menge zurückgegeben: {menge}");
                    Console.WriteLine($"Einzelpreis: {einzelpreis:C}");
                    Console.WriteLine($"Gesamtpreis (Retoure): {gesamtpreis:C}");
                    Console.WriteLine("--------------------------------------------------");

                    // Bestandsänderung für die Retoure: Bestände wieder aufstocken
                    BestandsAenderung(artikelnummer, -menge); // Negative Menge, da Artikel zurückgegeben werden
                }
            }

            Console.WriteLine($"Gesamtbetrag der Retoure: {gesamtbetrag:C}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(isRechnung ? "Retoure abgeschlossen." : "Bestellung abgeschlossen.\n");

        }

        
    }
}