using Proxy.Theoretical;
using Proxy.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

MyProxy proxy = new MyProxy();
proxy.Operation();
proxy.Operation();
proxy.Operation();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

IImage image1 = new ProxyImage(fileName: "image1");
IImage image2 = new ProxyImage(fileName: "image2");

Console.WriteLine("Displaying image 1");
image1.Display();

Console.WriteLine("Displaying image 2");
image2.Display();

Console.WriteLine("Displaying image 1 again");
image1.Display();
