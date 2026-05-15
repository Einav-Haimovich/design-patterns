namespace Decorator.Theoretical;

public class ConcreteDecorator2(Component component) : Decorator(component)
{
    public override void Operation()
    {
        Console.WriteLine("-------- Concrete Decorator 2 -----------");
        _component.Operation();
        Console.WriteLine("-------- Concrete Decorator 2 -----------");
    }
}