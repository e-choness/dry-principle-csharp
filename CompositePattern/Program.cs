// See https://aka.ms/new-console-template for more information

using CompositePattern;

IComponent leaf1 = new Leaf("Leaf 1");
IComponent leaf2 = new Leaf("leaf 2");
IComponent leaf3 = new Leaf("leaf 3");

Composite composite1 = new("Composite 1");
Composite composite2 = new("Composite 2");

composite1.Add(leaf1);
composite1.Add(leaf2);

composite2.Add(leaf3);

Composite root = new("Root");
root.Add(composite1);
root.Add(composite2);

root.Display(0);