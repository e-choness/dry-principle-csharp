namespace VisitorPattern;

public class Operation
{
    private List<IElement> _elements;

    public Operation()
    {
        _elements = new List<IElement>();
    }

    public Operation(List<IElement> elements)
    {
        _elements = elements;
    }

    public void Attach(IElement element)
    {
        _elements.Add(element);
    }

    public void Remove(IElement element)
    {
        _elements.Remove(element);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }
}