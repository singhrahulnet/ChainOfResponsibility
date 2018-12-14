using ShipmentSolution.Domain.Handler;

namespace ShipmentSolution.Packages
{
    public class MediumPackage : PackageHandler
    {
        public override int Length => 300;
        public override int Breadth => 400;
        public override int Height => 200;
        public override int Cost => 10;
    }
}
