namespace VisitorPattern;

public interface IVisitor
{
    void VisitElementA(ElementA elementA);
    void VisitElementB(ElementB elementB);
}