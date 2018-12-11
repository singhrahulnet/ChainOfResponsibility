namespace ShipmentSolution.Models
{
    public interface IPackageDimension
    {
        int Length { get; set; }
        int Breadth { get; set; }
        int Height { get; set; }
        int Weight { get; set; }
    }
    public class PackageDimension : IPackageDimension
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
