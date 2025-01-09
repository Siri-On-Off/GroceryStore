using System;
using GroceryStore;

namespace Grocerystore
{
    public class Artikelstamm
    {
        private List<Artikel> artikelstammList = new List<Artikel>();
        private List<int> artikelnummerList = new List<int>();

        public void AddArtikel()
        {
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.ObstUndGemüse, 12345, "Apfel", 0.50, 2.00, 600, "Stk", true));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.ObstUndGemüse, 23456, "Gurke", 0.49, 0.99, 50, "Stk", true));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.ObstUndGemüse, 34567, "Banane", 0.10, 0.25, 60, "Stk", true));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.ObstUndGemüse, 45678, "Karotte", 0.85, 2.25, 20, "Pkg", true));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.ObstUndGemüse, 56789, "Brokkoli", 0.76, 2.00, 5, "Stk", true));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.Backwaren, 9101112, "Croissant", 0.30, 1.25, 30, "Stk", false));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.Backwaren, 10111213, "Brot", 2.21, 3.75, 43, "Stk", true));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.Milchprodukte, 11121314, "Raclette", 8.03, 10.99, 26, "Pkg", false));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.Milchprodukte, 15161718, "Joghurt", 0.22, 0.60, 20, "Stk", false));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.Konserven, 19202122, "Bohnen", 0.62, 1.25, 60, "Dose", true));
            artikelstammList.Add(new Lebensmittel(Artikelgruppe.Konserven, 20212223, "Mais", 0.59, 0.99, 30, "Dose", true));
            artikelstammList.Add(new Getraenk(Artikelgruppe.Softdrink, 21222324, "Cola", 1.00, 1.75, 100, "Dose", 0.33));
            artikelstammList.Add(new Getraenk(Artikelgruppe.Softdrink, 22232425, "Sinalco", 0.80, 1.75, 100, "Fl", 0.50));
            artikelstammList.Add(new Getraenk(Artikelgruppe.Softdrink, 23242526, "Orangina", 0.99, 1.75, 100, "Fl", 0.50));
            artikelstammList.Add(new Getraenk(Artikelgruppe.Alkohol, 24252627, "Weissbier", 0.26, 1.20, 92, "Flasche", 0.75));
            artikelstammList.Add(new Getraenk(Artikelgruppe.Alkohol, 25262728, "Lager", 0.75, 1.35, 34, "Dose", 0.50));
            artikelstammList.Add(new Getraenk(Artikelgruppe.Alkohol, 26272829, "Obstler", 1.00, 1.75, 100, "Dose", 0.33));

            foreach (var artikel in artikelstammList)
            {
                artikelnummerList.Add(artikel.Artikelnummer);
            }
        }

        public List<Artikel> ArtikelstammList => artikelstammList;

        public List<int> ArtikelnummerList => artikelnummerList;

        public bool IsValidArtikelnummer(int artikelnummer)
        {
            return artikelstammList.Any(artikel => artikel.Artikelnummer == artikelnummer);
        }

        public Artikel GetArtikelByArtikelnummer(int artikelnummer)
        {
            return artikelstammList.FirstOrDefault(artikel => artikel.Artikelnummer == artikelnummer);
        }
    }
}
