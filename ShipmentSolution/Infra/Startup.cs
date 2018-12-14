using Microsoft.Extensions.DependencyInjection;
using ShipmentSolution.Domain;
using ShipmentSolution.IOService;
using ShipmentSolution.Models;
using System;

namespace ShipmentSolution.Infra
{
    class Startup : IStartup
    {
        public IServiceProvider Init()
        {
            IServiceProvider serviceProvider = new ServiceCollection()
           .AddSingleton<IPackageInventory, PackageInventory>()
           .AddSingleton<IArgs, Arguments>()
           .AddScoped<IResult, Result>()
           .AddScoped<IInputService, InputService>()
           .AddScoped<IOutputService, OutputService>()
           .AddScoped<ICostCalculatorLoop, CostCalculatorLoop>()
           .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
