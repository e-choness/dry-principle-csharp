namespace DryLibrary.Interfaces;

public interface IProduct
{
    string Id { get; set; }
    string Title { get; set; }
    string Subtitle { get; set; }
    DateTime TransactionDate { get; set; }
}