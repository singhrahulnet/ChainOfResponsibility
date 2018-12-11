using ShipmentSolution.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentSolution.Domain
{
    interface IRules
    {
        bool OverWeight(IPackageDimension packageDimension);
        bool OverSized(IPackageDimension packageDimension);
    }
}
