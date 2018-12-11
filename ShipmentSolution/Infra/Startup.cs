using ShipmentSolution.Domain.Handler;
using System.Collections.Generic;

namespace ShipmentSolution.Infra
{
    class Startup : IStartup
    {
        private SortedList<int, PackageHandler> _packages;

        public Startup(SortedList<int, PackageHandler> packages)
        {
            _packages = packages;
        }

        public void SetChain()
        {
            for (int i = 0; i < _packages.Count - 1; i++)
            {
                _packages.Values[i].SetNextPackage(_packages.Values[i + 1]);
            }
        }
    }
}
