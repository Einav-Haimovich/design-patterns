namespace Mediator.Theoretical;

public interface Mediator
{
    void Notify(Colleague sender, string @event);
}