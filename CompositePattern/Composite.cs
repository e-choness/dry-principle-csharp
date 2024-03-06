using ExtensionsLibrary;

namespace CompositePattern;

public class Composite : IComponent
{
    private List<IComponent> children = new();
    
    public string Name { get; }

    public Composite(string name)
    {
        Name = name;
    }

    public void Add(IComponent component)
    {
        children.Add(component);
    }

    public void Remove(IComponent component)
    {
        children.Remove(component);
    }
    
    public void Display(int depth)
    {
        (new string('-', depth) + "Composite: " + Name).Dump();
        
        // Recursively display child components
        foreach (var child in children)
        {
            child.Display(depth + 2);
        }
    }
}