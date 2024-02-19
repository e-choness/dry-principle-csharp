// See https://aka.ms/new-console-template for more information

using AsyncDummyLib;

var threadRunner = new ThreadRunner();
var isFinished = await threadRunner.RunThreadsAsync();
Console.WriteLine(isFinished);