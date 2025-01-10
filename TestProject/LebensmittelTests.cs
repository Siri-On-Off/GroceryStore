using Grocerystore;

namespace TestProject;

[TestClass]
public class LebensmittelTests
{
    [TestMethod]
    public void ReduziereBestand_BestandWirdReduziert()
    {
        // Arrange
        var lebensmittel = new Lebensmittel(Artikelgruppe.ObstUndGemüse, 1, "Apfel", 0.5, 1.0, 100, "Stück", true);
        int bestandAbgang = 20;

        // Act
        lebensmittel.ReduziereBestand(bestandAbgang);

        // Assert
        Assert.AreEqual(80, lebensmittel.Bestand);
    }

    [TestMethod]
    public void AddiereBestand_BestandWirdErhöht()
    {
        // Arrange
        var lebensmittel = new Lebensmittel(Artikelgruppe.ObstUndGemüse, 1, "Apfel", 0.5, 1.0, 100, "Stück", true);
        int bestandZugang = 30;

        // Act
        lebensmittel.AddiereBestand(bestandZugang);

        // Assert
        Assert.AreEqual(130, lebensmittel.Bestand);
    }

    [TestMethod]
    public void GruppeProperty_SetAndGet_ReturnsCorrectValue()
    {
        // Arrange
        var lebensmittel = new Lebensmittel(Artikelgruppe.Softdrink, 3, "Saft", 1.0, 2.0, 200, "Flasche", true);
        var expectedGruppe = new List<Artikelgruppe> { Artikelgruppe.ObstUndGemüse, Artikelgruppe.ObstUndGemüse };

        // Act
        lebensmittel.Gruppe = expectedGruppe;

        // Assert
        CollectionAssert.AreEqual(expectedGruppe, lebensmittel.Gruppe);
    }
}