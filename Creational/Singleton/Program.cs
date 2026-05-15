using Microsoft.Extensions.DependencyInjection;
using Singleton.Implementations;

Console.WriteLine("=== Singleton Pattern Implementations ===");
Console.WriteLine();

// 1. Naive Singleton
var instance1 = NaiveSingleton.Instance;
var instance2 = NaiveSingleton.Instance;
Console.WriteLine($"NaiveSingleton - Same instance: {ReferenceEquals(instance1, instance2)}");

// 2. Singleton via DI Container
IServiceCollection services = new ServiceCollection();
services.AddSingleton<Logger>();

var serviceProvider = services.BuildServiceProvider();
var logger1 = serviceProvider.GetRequiredService<Logger>();
var logger2 = serviceProvider.GetRequiredService<Logger>();
Console.WriteLine($"DI Singleton - Same instance: {ReferenceEquals(logger1, logger2)}");

class Logger { }
