using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Models;
using ShipmentSolution.Handler;

namespace ShipmentSolution.Packages
{
    class LargePackage : PackageHandler
    {

        public override void HandlePackage(PackageDimension dimension)
        {
            if (IsPackageBigger(dimension))
            {
                nextPackage.HandlePackage(dimension);
            }
        }

        private bool IsPackageBigger(PackageDimension dimension)
        {
            if (dimension.Length > 400 || dimension.Breadth > 600 || dimension.Height > 250)
            {
                return true;
            }
            return false;
        }
    }
}
