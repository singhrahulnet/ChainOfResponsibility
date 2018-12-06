using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Handler;
using ShipmentSolution.Packages;

namespace ShipmentSolution.Infra
{
    public class PackageInventory : IPackageInventory
    {
        private SortedList<int, PackageHandler> _allpackages;

        public PackageInventory()
        {
            GetAllAvailablePackages();
        }

        public PackageHandler SmallestPackage
        {
            get { return _allpackages.Values[0]; }
        }

        public SortedList<int, PackageHandler> AllAvailablePackages
        {
            get { return _allpackages; }
        }

        private void GetAllAvailablePackages()
        {
            _allpackages = new SortedList<int, PackageHandler>();
            _allpackages.Add(10, new SmallPackage());
            _allpackages.Add(20, new MediumPackage());
            _allpackages.Add(30, new LargePackage());
            _allpackages.Add(40, new NotAvailablePackage());

        }
    }
}
