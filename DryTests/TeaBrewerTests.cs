using AsyncDummyLib;

namespace DryTests;

public class TeaBrewerTests
{
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void MakeTeaAsyncTest()
    {
        var expected = "pour boiling water in cups.";
        var result = TeaBrewer.MakeTeaAsync();
        
        Assert.That(result.Result, Is.EqualTo(expected));
    }
}