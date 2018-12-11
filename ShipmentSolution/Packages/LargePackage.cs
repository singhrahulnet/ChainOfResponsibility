using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Models;

namespace ShipmentSolution.Packages
{
    public class LargePackage : PackageHandler
    {
        public override bool OverSized(IPackageDimension dimension)
        {
            if (dimension.Length > 400 || dimension.Breadth > 600 || dimension.Height > 250)
            {
                return true;
            }
            return false;
        }
    }
}
