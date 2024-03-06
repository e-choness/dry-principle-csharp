using ExtensionsLibrary;

namespace StrategyPattern;

public class StrategyA : IStrategy
{
    public void Execute()
    {
        "Executing Strategy A...".Dump();
    }
}