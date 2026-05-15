namespace Mediator.RealWorld;

public interface IChatMediator
{
    void Notify(User sender, string @event);
}