namespace Mediator;

public class RegularUser(string name) : User(name)
{
    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"{Name} receives from {senderName}: {message}");
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");

        _mediator.Notify(this, message);
    }
}