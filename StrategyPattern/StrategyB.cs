using ExtensionsLibrary;

namespace StrategyPattern;

public class StrategyB : IStrategy
{
    public void Execute()
    {
        "Executing Strategy B...".Dump();
    }
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void RunStrategy()
    {
        _strategy.Execute();
    }
}