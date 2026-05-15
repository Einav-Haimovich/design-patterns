using Facade.Theoretical;
using Facade.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

var facade = new Facade.Theoretical.Facade();
facade.Operation1();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

var castingFacade = new CastingFacade(
    new DeviceExplorer());

await castingFacade.CastAsync(
    deviceId: Guid.NewGuid(),
    videoId: Guid.NewGuid());
