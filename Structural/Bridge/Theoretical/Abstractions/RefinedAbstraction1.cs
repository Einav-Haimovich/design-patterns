namespace Bridge.Theoretical;

public class RefinedAbstraction1(Implementor implementor) : Abstraction(implementor)
{
    public override void Foo()
    {
        Implementor.Print();
    }
}