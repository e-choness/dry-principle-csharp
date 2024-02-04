using DryLibrary.Services;

namespace DryTests;

public class DocumentReaderUnitTests
{
    private const string FilePath = @"D:\projects\dry-principle-csharp\Dry\DryTests\Resources\FileToRead.txt";
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void LoadFileTest()
    {
        string expectedString = "THis is a file for the test.";
        
        Assert.That(true, expectedString, DocumentReader.Load(FilePath));
    }
}