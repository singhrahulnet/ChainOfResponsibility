using ShipmentSolution.Domain.Handler;
using ShipmentSolution.Models;
using System;

namespace ShipmentSolution.Packages
{
    public class NotAvailablePackage : PackageHandler
    {
        public override int Length
        {
            get =>

throw new Exception("Larger Package Not Available");

            set => throw new NotImplementedException();
        }
        public override int Breadth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
