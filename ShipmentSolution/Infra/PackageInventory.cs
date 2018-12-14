using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Packages;
using System.Collections.Generic;

namespace ShipmentSolution.Infra
{
    public class PackageInventory : IPackageInventory
    {
        private SortedList<int, PackageHandler> _allpackages;

        public PackageInventory()
        {
            InitAllAvailablePackages();
            SetChain();
        }

        private void SetChain()
        {
            for (int i = 0; i < _allpackages.Count - 1; i++)
            {
                _allpackages.Values[i].SetNextPackage(_allpackages.Values[i + 1]);
            }
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
            _allpackages = new SortedList<int, PackageHandler>
            {
                { 10, new SmallPackage() },
                { 20, new MediumPackage() },
                { 30, new LargePackage() }
            };
        }
    }
}
