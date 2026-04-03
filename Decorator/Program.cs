using Decorator;

ITeslaModel3 car = new LongRangeTeslaDecorator(
    car: new RedPaintTeslaDecorator(
        car: new BasicTeslaModel3()));

Console.WriteLine($"Description: {car.GetDescription()}");
Console.WriteLine($"Price: {car.GetPrice()}");
Console.WriteLine($"Range: {car.GetRange()}");