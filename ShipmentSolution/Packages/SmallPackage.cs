using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Models;

namespace ShipmentSolution.Packages
{
    public class SmallPackage : PackageHandler
    {
        public override int Length { get; set; } = 200;
        public override int Breadth { get; set; } = 400;
        public override int Height { get; set; } = 150;        
    }
}
