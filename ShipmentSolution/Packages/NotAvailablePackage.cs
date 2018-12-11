using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Models;
using System;

namespace ShipmentSolution.Packages
{
    public class NotAvailablePackage : PackageHandler
    {        
        public override bool OverSized(IPackageDimension dimension)
        {
            throw new Exception("Larger Package not available.");
        }
    }
}
