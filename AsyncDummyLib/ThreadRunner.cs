namespace AsyncDummyLib;

public class ThreadRunner
{
    async Task RunThreadsAsync()
    {
        Thread.CurrentThread.ManagedThreadId.Dump("1");
        var client = new HttpClient();
        Thread.CurrentThread.ManagedThreadId.Dump("2");
        var task = client.GetStringAsync("https://www.google.com");
        Thread.CurrentThread.ManagedThreadId.Dump("3");

        var a = 0;
        for (var i = 0; i < 1_000_1000; i++)
        {
            a += i;
        }

        Thread.CurrentThread.ManagedThreadId.Dump("4");
        var page = await task;
        Thread.CurrentThread.ManagedThreadId.Dump("5");
    }
}