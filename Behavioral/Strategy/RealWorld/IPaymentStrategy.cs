namespace Strategy.RealWorld;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}