using Dumpify;
using Prototype.Models;

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

IShape circle = new Circle(radius: 100, color: Color.LightGrey);
IShape rectangle = new Rectangle(width: 100, height: 100, Color.LightGrey);

void CloneDrag(IShape shape)
{
    var newShape = shape.Clone();
    //while (isMousDown)
    //{

    //}
}

var newCircle = circle.Clone();
var newRectangle = rectangle.Clone();

newCircle.Dump();
newRectangle.Dump();