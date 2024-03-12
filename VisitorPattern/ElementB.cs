namespace VisitorPattern;

public class ElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitElementB(this);
    }

    public void DoSomethingForB()
    {
        Console.WriteLine("Do something for Element B.");
    }
}