namespace Observer.Theoretical;

public class ConcreteObserver(ConcreteSubject subject) : Observer
{
    private readonly ConcreteSubject _subject = subject;

    public void Update()
    {
        var state = _subject.GetState();
        Console.WriteLine($"Observer reacted to the state: {state}");
    }
}
