using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Models;

namespace ShipmentSolution.Packages
{
    public class LargePackage : PackageHandler
    {
        public override int Length { get; set; } = 400;
        public override int Breadth { get; set; } = 600;
        public override int Height { get; set; } = 250;        
    }
}
