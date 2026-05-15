using AbstractFactory.Theoretical;

namespace AbstractFactory.Theoretical;

public class ConcreteFactory : AbstractFactory
{
    public override Product1 CreateProduct1()
    {
        return new ConcreteProduct1();
    }

    public override Product2 CreateProduct2()
    {
        return new ConcreteProduct2();
    }
}