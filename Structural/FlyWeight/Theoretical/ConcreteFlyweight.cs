namespace FlyWeight.Theoretical;

public class ConcreteFlyweight(string intrinsicState) : Flyweight
{
    private readonly string intrinsicState = intrinsicState;

    public void Operation(string extrinsicState)
    {
        Console.WriteLine($"Concrete Flyweight: Intrinsic state: {intrinsicState}, Extrinsic state: {extrinsicState}");
    }
}
