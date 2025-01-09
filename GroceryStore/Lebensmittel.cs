using System;
using System.Collections.Generic;
using GroceryStore;

namespace Grocerystore
{
    public class Lebensmittel : Artikel
    {
        private bool vegan;

        private List<Artikelgruppe> gruppe = new List<Artikelgruppe>();

        public Lebensmittel(Artikelgruppe artikelgruppe, int artikelnummer, string bezeichnung, double einkaufspreis,
            double preis, int bestand, string einheit, bool vegan)
            : base(artikelgruppe, artikelnummer, bezeichnung, einkaufspreis, preis, bestand, einheit)
        {
            this.vegan = vegan;

        }

        public bool Vegan
        {
            get { return vegan; }
            set { vegan = value; }
        }

        public List<Artikelgruppe> Gruppe
        {
            get { return gruppe; }
            set { gruppe = value; }
        }
    }
}