using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Models;

namespace ShipmentSolution.Packages
{
    public class MediumPackage : PackageHandler
    {
        public override bool OverSized(IPackageDimension dimension)
        {
            if (dimension.Length > 300 || dimension.Breadth > 400 || dimension.Height > 200)
            {
                return true;
            }
            return false;
        }
    }
}
