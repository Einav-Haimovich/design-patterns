using Decorator.Theoretical;
using Decorator.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

Component component = new ConcreteDecorator2(
    component: new ConcreteDecorator1(
        component: new ConcreteDecorator1(
            component: new ConcreteComponent())));

component.Operation();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

ITeslaModel3 car = new LongRangeTeslaDecorator(
    car: new RedPaintTeslaDecorator(
        car: new BasicTeslaModel3()));

Console.WriteLine($"Description: {car.GetDescription()}");
Console.WriteLine($"Price: {car.GetPrice()}");
Console.WriteLine($"Range: {car.GetRange()}");
