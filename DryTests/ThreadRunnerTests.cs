using AsyncDummyLib;

namespace DryTests;

public class ThreadRunnerTests
{
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void RunThreadsTest()
    {
        var result = ThreadRunner.RunThreadsAsync();
        Assert.That(result.Result, Is.True);
    }
}