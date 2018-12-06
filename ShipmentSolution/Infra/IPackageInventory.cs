using ShipmentSolution.Handler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentSolution.Infra
{
    public interface IPackageInventory
    {
        PackageHandler SmallestPackage { get; }
        SortedList<int, PackageHandler> AllAvailablePackages { get; }
    }
}
