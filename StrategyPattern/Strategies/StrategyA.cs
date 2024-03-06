using ExtensionsLibrary;

namespace StrategyPattern.Strategies;

public class StrategyA : IStrategy
{
    public void Execute()
    {
        "Executing Strategy A...".Dump();
    }
}