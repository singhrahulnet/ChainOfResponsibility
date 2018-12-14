namespace ShipmentSolution.Domain
{
    public class Result : IResult
    {
        public int FinalCost { get; set; }
        public string PackageType { get; set; }
    }
}
