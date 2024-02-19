using AsyncDummyLib;

namespace DryTests;

public class ThreadRunnerTests
{
    private ThreadRunner _threadRunner;
    [SetUp]
    public void SetUp()
    {
        _threadRunner = new ThreadRunner();
    }

    [Test]
    public void RunThreadsTest()
    {
        var result = _threadRunner.RunThreadsAsync();
        Assert.That(result.Result, Is.True);
    }
}