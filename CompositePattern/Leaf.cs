using ExtensionsLibrary;

namespace CompositePattern;

public class Leaf : IComponent
{
    public string Name { get; }

    public Leaf(string name)
    {
        Name = name;
    }
    
    public void Display(int depth)
    {
        (new string('-', depth) + Name).Dump();
    }
}