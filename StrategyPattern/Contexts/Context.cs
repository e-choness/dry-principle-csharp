using StrategyPattern.Strategies;

namespace StrategyPattern.Contexts;

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