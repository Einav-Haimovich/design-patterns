using Factory.Theoretical;

namespace Factory.Theoretical;

public class ConcreteCreator : Creator
{
    public override Product CreateProduct()
    {
        return new ConcreteProduct();
    }
}