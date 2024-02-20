// See https://aka.ms/new-console-template for more information

using AsyncDummyLib;

var isFinished = await ThreadRunner.RunThreadsAsync();
isFinished.Dump();

var tea = await TeaBrewer.MakeTeaAsync();
tea.Dump();
