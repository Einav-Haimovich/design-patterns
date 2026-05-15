using Strategy.Theoretical;
using Strategy.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

Context context = new();

context.SetStrategy(new ConcreteStrategyA());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyC());
context.ExecuteStrategy();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

ShoppingCart cart = new();

cart.SetStrategy(new CreditCardStrategy(
    name: "John Doe",
    cardNumber: "123456789123456",
    cvv: "344",
    dateOfExpiry: "01/28"
));

cart.Checkout(100.50m);

cart.SetStrategy(new PayPalStrategy(
    email: "john@doe.com",
    password: "mypassword"
));

cart.Checkout(10.3m);

cart.SetStrategy(new BankTransferStrategy(
    bankName: "MyBank",
    accountNumber: "ABC123"
));

cart.Checkout(200m);
