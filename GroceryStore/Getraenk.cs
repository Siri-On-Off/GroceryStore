using GroceryStore;

namespace Grocerystore
{
    public class Getraenk : Artikel
    {
        private double liter;

        public Getraenk(Artikelgruppe artikelgruppe, int artikelnummer, string bezeichnung, double einkaufspreis,
            double preis, int bestand, string einheit, double liter)
            : base(artikelgruppe, artikelnummer, bezeichnung, einkaufspreis, preis, bestand, einheit)
        {
            this.liter = liter;
        }

        public double Liter
        {
            get { return liter; }
            set { liter = value; }
        }
    }
}