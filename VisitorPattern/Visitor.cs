namespace VisitorPattern;

public class Visitor : IVisitor
{
    public void VisitElementA(ElementA elementA)
    {
        Console.WriteLine("Visiting element A...");
        elementA.DoSomethingForA();
    }

    public void VisitElementB(ElementB elementB)
    {
        Console.WriteLine("Visiting element B...");
        elementB.DoSomethingForB();
    }
}