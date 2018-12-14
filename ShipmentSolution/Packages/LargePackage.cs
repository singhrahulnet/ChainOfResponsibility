using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Models;

namespace ShipmentSolution.Packages
{
    public class LargePackage : PackageHandler
    {
        public override int Length => 400;
        public override int Breadth => 600;
        public override int Height => 250;
        public override int Cost => 15;
    }
}
