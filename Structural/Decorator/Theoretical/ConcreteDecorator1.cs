namespace Decorator.Theoretical;

public class ConcreteDecorator1(Component component) : Decorator(component)
{
    public override void Operation()
    {
        Console.WriteLine("-------- Concrete Decorator 1 -----------");
        _component.Operation();
        Console.WriteLine("-------- Concrete Decorator 1 -----------");
    }
}