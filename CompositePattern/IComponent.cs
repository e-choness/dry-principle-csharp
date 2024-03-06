namespace CompositePattern;

public interface IComponent
{
    string Name { get; }
    void Display(int depth);
}