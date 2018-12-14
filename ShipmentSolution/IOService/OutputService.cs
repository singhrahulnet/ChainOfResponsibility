using ShipmentSolution.Domain;
using System;

namespace ShipmentSolution.IOService
{
    public class OutputService : IOutputService
    {
        private IResult _result;
        public OutputService(IResult result)
        {
            _result = result;
        }
        public void WriteInitMessage()
        {
            Console.WriteLine("******For Reference*******");
            Console.WriteLine("Small Range = 200, 300, 150");
            Console.WriteLine("Medium Range = 300, 400, 200");
            Console.WriteLine("Large Range = 400, 600, 250");
            Console.WriteLine("Max Weight 25kg");
            Console.WriteLine("**************************");
            Console.WriteLine();

            Console.WriteLine("Enter L, B, H and Weight. Each followed by an 'Enter' ");
        }

        public void WriteResultMessage(IResult result)
        {
            Console.WriteLine("******The Result*******");
            Console.WriteLine("Package Cost: {0}, Package Type: {1}", result.FinalCost, result.PackageType);
            Console.WriteLine("***********************");            
        }
    }
}
