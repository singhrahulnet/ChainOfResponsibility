using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Models;
using ShipmentSolution.Handler;

namespace ShipmentSolution.Packages
{
    class MediumPackage : PackageHandler
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
            if (dimension.Length > 300 || dimension.Breadth > 400 || dimension.Height > 200)
            {
                return true;
            }
            return false;
        }
    }
}
