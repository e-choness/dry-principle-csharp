using DryFrameworkLibrary.Interfaces;
using DryFrameworkLibrary.Models;
using DryFrameworkLibrary.Services;

namespace DryTests;

public class ProductProcessorUnitTests
{
    private IProduct game;
    private ProductProcessor _processor;
    
    [SetUp]
    public void Setup()
    {
        game = new Game();
        _processor = new ProductProcessor();
    }

    [Test]
    public void GetNameTest()
    {
        var title = "The Elder Scrolls";
        var subtile = "Skyrim";
        var transactionDate = DateTime.Now;

        game.Title = title;
        game.Subtitle = subtile;
        game.TransactionDate = transactionDate;

        var resultId =_processor.GenerateProductId(game);
        Assert.That(true, $"TheSky{transactionDate}", resultId);
    }
}