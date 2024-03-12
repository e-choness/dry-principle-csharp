namespace VisitorPattern;

public interface IElement
{
    void Accept(IVisitor visitor);
}