using _3._7;
using Builder;
using Builder.Builders;
using Dumpify;

//IBuilder builder = new SimpleProductBuilder();
IBuilder builder = new ComplexProductBuilder();
ProductDirector director = new ProductDirector(builder);

director.Construct();
Product product1 = builder.Build();

product1.Dump();

// 1. Identify the distinct steps
// 2. Define each step as an interface
// 3. Add a method (one or more) that move you to the next step
// 4. Have the last step build the underlying product
// 5. Implement the interfaces in the builder
// 6. Add an entry point in the builder, that returns the first step
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