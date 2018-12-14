using ShipmentSolution.Domain;

namespace ShipmentSolution.IOService
{
    public interface IOutputService
    {
        void WriteInitMessage();
        void WriteResultMessage(IResult result);
    }
}
