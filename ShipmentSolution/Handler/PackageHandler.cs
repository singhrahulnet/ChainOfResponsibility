using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Models;

namespace ShipmentSolution.Handler
{
    public abstract class PackageHandler
    {
        protected PackageHandler nextPackage;

        public void SetNextPackage(PackageHandler next)
        {
            nextPackage = next;
        }

        public abstract void HandlePackage(PackageDimension dimension);

        public const int MaxWeight  = 25;
    }
}
