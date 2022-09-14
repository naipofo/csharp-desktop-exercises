using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_mstest_classes.Tests;

[TestClass]
public class ReverseManipulatorTest
{
    [TestMethod]
    public void TestMethod1()
    {
        var m = new _02_mstest_classes.Core.ReverseStringManipulator();
        Assert.AreEqual(m.Manipulate("Asd"), "dsA");
        Assert.AreEqual(m.Manipulate("貴方я и ты"), "ыт и я方貴");
    }
}