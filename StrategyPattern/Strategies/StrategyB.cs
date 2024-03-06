using ExtensionsLibrary;

namespace StrategyPattern.Strategies;

public class StrategyB : IStrategy
{
    public void Execute()
    {
        "Executing Strategy B...".Dump();
    }
}