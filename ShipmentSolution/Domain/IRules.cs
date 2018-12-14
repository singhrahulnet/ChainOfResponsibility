using ShipmentSolution.Models;

namespace ShipmentSolution.Domain
{
    interface IRules
    {
        bool OverWeight(IArgs packageDimension);
        bool OverSized(IArgs packageDimension);
    }
}
