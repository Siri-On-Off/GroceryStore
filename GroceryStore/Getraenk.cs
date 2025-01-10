using GroceryStore;

namespace Grocerystore
{
    public class Getraenk : Artikel
    {
        public double liter { get; set; }

        public Getraenk(Artikelgruppe artikelgruppe, int artikelnummer, string bezeichnung, double einkaufspreis,
            double preis, int bestand, string einheit, double liter)
            : base(artikelgruppe, artikelnummer, bezeichnung, einkaufspreis, preis, bestand, einheit)
        {
            this.liter = liter;
        }

    }
}