using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_mstest_classes.Tests;

[TestClass]
public class SuffixManipulatorTest
{
    [TestMethod]
    public void TestMethod1()
    {
        var m = new _02_mstest_classes.Core.SuffixStringManipulator();
        Assert.AreEqual(m.Manipulate("Asd"), "Asd_123");
        Assert.AreEqual(m.Manipulate("ああ"), "ああ_123");
    }
}