namespace Observer.Theoretical;

public interface Subject
{
    void Attach(Observer observer);
    void Detach(Observer observer);
    void Notify();
}