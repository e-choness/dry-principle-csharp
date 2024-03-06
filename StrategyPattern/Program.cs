// See https://aka.ms/new-console-template for more information

using StrategyPattern;

// Set first strategy at compile time
Context context = new(new StrategyA());
context.RunStrategy();

// Change strategy at runtime
context.SetStrategy(new StrategyB());
context.RunStrategy();