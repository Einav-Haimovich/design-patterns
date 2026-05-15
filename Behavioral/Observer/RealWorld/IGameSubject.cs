namespace Observer.RealWorld;


public interface IGameSubject
{
    void Attach(IGameObserver observer);
    void Detach(IGameObserver observer);
    void Notify();
}