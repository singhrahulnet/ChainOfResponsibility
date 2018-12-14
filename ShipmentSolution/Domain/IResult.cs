namespace ShipmentSolution.Domain
{
    public interface IResult
    {
        int FinalCost { get; set; }
        string PackageType { get; set; }
    }
}
