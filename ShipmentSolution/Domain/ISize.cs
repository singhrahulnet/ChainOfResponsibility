using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentSolution.Domain
{
    public interface ISize
    {
        int Length { get; set; }
        int Breadth { get; set; }
        int Height { get; set; }
    }
}
