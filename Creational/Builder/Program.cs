using Builder.Theoretical;
using Builder.RealWorld;
using Dumpify;

Console.WriteLine("=== Theoretical Example (GoF) ===");

IBuilder builder = new ComplexProductBuilder();
ProductDirector director = new ProductDirector(builder);

director.Construct();
Product product1 = builder.Build();
product1.Dump();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

Pizza product2 = Pizza.Builder.Empty()
    .SetDough(dough => dough
        .SetThickness(3)
        .SetFlour("whole wheat"))
    .SetSauce("Spicy tomato sauce")
    .SetCheese("Vegan cheese")
    .AddTopping("Olives")
    .AddTopping("Onions")
    .Build();

product2.Dump();
