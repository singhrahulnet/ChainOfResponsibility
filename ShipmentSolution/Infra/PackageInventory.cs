using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Packages;

namespace ShipmentSolution.Infra
{
    public class PackageInventory : IPackageInventory
    {
        private SortedList<int, PackageHandler> _allpackages;

        public PackageInventory()
        {
            InitAllAvailablePackages();
        }

        public PackageHandler SmallestPackage
        {
            get { return _allpackages.Values[0]; }
        }

        public SortedList<int, PackageHandler> AllAvailablePackages
        {
            get { return _allpackages; }
        }

        private void InitAllAvailablePackages()
        {
            _allpackages = new SortedList<int, PackageHandler>();
            _allpackages.Add(10, new SmallPackage());
            _allpackages.Add(20, new MediumPackage());
            _allpackages.Add(30, new LargePackage());
            _allpackages.Add(40, new NotAvailablePackage());
        }
    }
}
