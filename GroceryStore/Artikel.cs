using Grocerystore;

namespace GroceryStore
{
    public abstract class Artikel
    {
        public Artikelgruppe Artikelgruppe { get; set; }
        public int Artikelnummer { get; }
        public string Bezeichnung { get; set; }
        public double Einkaufspreis { get; set; }
        public double Preis { get; set; }
        public int Bestand { get; private set; }
        public string Einheit { get; set; }

        public Artikel(Artikelgruppe artikelgruppe, int artikelnummer, string bezeichnung, double einkaufspreis, double preis, int bestand, string einheit)
        {
            Artikelgruppe = artikelgruppe;
            Artikelnummer = artikelnummer;
            Bezeichnung = bezeichnung;
            Einkaufspreis = einkaufspreis;
            Preis = preis;
            Bestand = bestand;
            Einheit = einheit;
        }

        public void ReduziereBestand(int bestandAbgang)
        {
            Bestand -= bestandAbgang;
        }

        public void AddiereBestand(int bestandZugang)
        {
            Bestand += bestandZugang;
        }
    }

   
}
