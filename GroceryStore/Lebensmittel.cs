using System;
using System.Collections.Generic;
using GroceryStore;

namespace Grocerystore
{
    public class Lebensmittel : Artikel
    {
        public bool Vegan { get; set; }
        public List<Artikelgruppe> Gruppe { get; set; }

        public Lebensmittel(Artikelgruppe artikelgruppe, int artikelnummer, string bezeichnung, double einkaufspreis,
            double preis, int bestand, string einheit, bool vegan)
            : base(artikelgruppe, artikelnummer, bezeichnung, einkaufspreis, preis, bestand, einheit)
        {
            this.Vegan = vegan;
        }

    }
}