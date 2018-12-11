using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Infra;
using ShipmentSolution.Models;

namespace ShipmentSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            IPackageInventory inventory = new PackageInventory();
            IStartup startup = new Startup(inventory.AllAvailablePackages);
            startup.SetChain();


            //IPackageDimension dimension = new PackageDimension { Length = 400, Breadth = 200, Height = 700, Weight = 20 };
            IPackageDimension dimension = new PackageDimension { Length = 300, Breadth = 400, Height = 200, Weight = 20 };

            inventory.SmallestPackage.HandlePackage(dimension);
        }
    }
}
