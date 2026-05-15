using Dumpify;
using Prototype.Theoretical;
using Prototype.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

Prototype.Theoretical.IPrototype prototype = new ConcretePrototype1();
var prototypeClone = prototype.Clone();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

var person = new Person("Einav", ["Training", "Studdying"]);
var shallowClonedPerson = person.ShallowClone();
var deepClonedPerson = person.DeepClone();

shallowClonedPerson.Hobbies.Add("Cooking");
shallowClonedPerson.Dump();
person.Dump();

deepClonedPerson.Hobbies.Add("Cooking");
person.Dump();
deepClonedPerson.Dump();

Console.WriteLine($"Copys are equal: {person == shallowClonedPerson}");
Console.WriteLine($"Copys are equal: {person == deepClonedPerson}");

Console.WriteLine($"Shallow copy is same reference: {ReferenceEquals(person, shallowClonedPerson)}");
Console.WriteLine($"Deep copy is same reference: {ReferenceEquals(person, deepClonedPerson)}");

Prototype.RealWorld.IShape circle = new Circle(radius: 100, color: Color.LightGrey);
Prototype.RealWorld.IShape rectangle = new Rectangle(width: 100, height: 100, Color.LightGrey);

var newCircle = circle.Clone();
var newRectangle = rectangle.Clone();

newCircle.Dump();
newRectangle.Dump();
