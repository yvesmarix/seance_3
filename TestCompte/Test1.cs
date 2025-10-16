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

    [TestMethod]
    public void TestVirement()
    {
        var compte1 = new CompteCourant();
        var compte2 = new CompteCourant();
        compte1.Deposer(500);
        compte1.Virement(300, compte2);
        Assert.AreEqual(300, compte2.Solde);
        Assert.AreEqual(200, compte1.Solde);
    }
}
