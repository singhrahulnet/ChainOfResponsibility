using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Models;

namespace ShipmentSolution.Packages
{
    public class SmallPackage : PackageHandler
    {        
        public override bool OverSized(IPackageDimension dimension)
        {
            if (dimension.Length > 200 || dimension.Breadth > 300 || dimension.Height > 150)
            {
                return true;
            }
            return false;
        }
    }
}
