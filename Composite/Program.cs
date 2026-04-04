// client code

using Composite;

LearningResource root = new Bundle(name: "Zero to Hero: Clean Architecture");

LearningResource leafA = new Course(
    name: "Getting Started: Clean Architecture",
    duration: TimeSpan.FromHours(3),
    price: 100);

LearningResource leafB = new Course(
    name: "Deep Dive: Clean Architecture",
    duration: TimeSpan.FromHours(4),
    price: 110);

root.Add(leafA);
root.Add(leafB);

Console.WriteLine(root.GetPrice());