using ShipmentSolution.Domain.Handler;
using System.Collections.Generic;

namespace ShipmentSolution.Infra
{
    public interface IPackageInventory
    {
        PackageHandler SmallestPackage { get; }
        SortedList<int, PackageHandler> AllAvailablePackages { get; }
    }
}
