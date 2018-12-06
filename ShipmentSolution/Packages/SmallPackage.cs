using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Models;
using ShipmentSolution.Handler;

namespace ShipmentSolution.Packages
{
    class SmallPackage : PackageHandler
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
            if (dimension.Length > 200 || dimension.Breadth > 300 || dimension.Height > 150)
            {
                return true;
            }
            return false;
        }
    }
}
