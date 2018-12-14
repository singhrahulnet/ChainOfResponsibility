using ShipmentSolution.Domain.Handler;

namespace ShipmentSolution.Packages
{
    public class SmallPackage : PackageHandler
    {
        public override int Length => 200;
        public override int Breadth => 300;
        public override int Height => 150;
        public override int Cost => 5;
    }
}
