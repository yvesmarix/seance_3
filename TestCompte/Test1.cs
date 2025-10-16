using seance_3;

namespace TestCompte;

[TestClass]
public sealed class CompteCourantTest
{

    [TestMethod]
    public void TestDepot()
    {
        var compte = new CompteCourant();
        compte.Deposer(100);
        Assert.AreEqual(100, compte.Solde);
    }
}
