using Microsoft.Extensions.DependencyInjection;
using ShipmentSolution.Infra;

namespace ShipmentSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            ICostCalculatorLoop loop = new Startup().Init().GetService<ICostCalculatorLoop>();
            loop.Run();
        }      
    }
}
