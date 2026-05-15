using Mediator.Theoretical;
using Mediator.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

Colleague1 colleague1 = new();
Colleague2 colleague2 = new();
ConcreteMediator mediator = new(colleague1, colleague2);

colleague1.Operation1();
colleague2.Operation2();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

ChatRoom chatRoom = new();

RegularUser alice = new("Alice");
RegularUser bob = new("Bob");
AdminUser charlie = new("Charlie");

chatRoom.AddUser(alice);
chatRoom.AddUser(bob);
chatRoom.AddUser(charlie);

charlie.Send("Welcome, everybody.");

alice.Send("Hello, everyone!");
bob.Send("Hi Alice, how are you?");
alice.Send("I'm good, thanks.");

charlie.BroadcastAlert("Keep it friendly guys!");
