using System;

namespace ShipmentSolution.Infra
{
    interface IStartup
    {
        IServiceProvider Init();
    }
}
