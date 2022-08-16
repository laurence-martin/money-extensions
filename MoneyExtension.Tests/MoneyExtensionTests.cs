namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.97M;
        var cents = valor.ToCents();
        Assert.AreEqual(27997, cents);
    }
}