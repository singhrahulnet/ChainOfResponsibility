using ShipmentSolution.Handler;
using ShipmentSolution.Infra;
using ShipmentSolution.Models;
using ShipmentSolution.Packages;
using System;
using System.Collections.Generic;

namespace ShipmentSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            IPackageInventory inventory = new PackageInventory();
            IStartup startup = new Startup(inventory.AllAvailablePackages);
            startup.SetChain();

            PackageDimension dimension = new PackageDimension { Length = 400, Breadth = 200, Height = 700 };

            inventory.SmallestPackage.HandlePackage(dimension);
        }
    }
}
