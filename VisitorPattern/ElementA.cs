namespace VisitorPattern;

public class ElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitElementA(this);
    }

    public void DoSomethingForA()
    {
        Console.WriteLine("Do something for Element A.");
    }
}