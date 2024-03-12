// See https://aka.ms/new-console-template for more information

using VisitorPattern;

Console.WriteLine("Welcome to Visitor Pattern showcase!");

Operation operation = new();

operation.Attach(new ElementA());
operation.Attach(new ElementB());

operation.Accept(new Visitor());