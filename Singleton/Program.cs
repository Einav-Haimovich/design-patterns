using System;
using FxResources.Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;


// Singleton pattern vs Singleton behavior via the DI Inversion Container (DI Container)
IServiceCollection services = new ServiceCollection();
services.AddSingleton<Logger>();

var serviceProvider = services.BuildServiceProvider();
var logger = serviceProvider.GetRequiredService<Logger>();


class Logger
{
    
}