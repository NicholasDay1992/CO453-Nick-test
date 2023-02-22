using ConsoleAppProject.App01;
namespace Test2;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        DistanceConverter converter = new DistanceConverter();
        converter.fromDistance = 17;
        Assert.AreEqual(converter.fromDistance, 17);

    }
}
