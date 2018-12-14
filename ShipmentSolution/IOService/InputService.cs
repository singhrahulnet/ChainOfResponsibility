using ShipmentSolution.Models;
using System;

namespace ShipmentSolution.IOService
{
    public class InputService : IInputService
    {
        private IArgs _args;
        public InputService(IArgs args)
        {
            _args = args;
        }
        public IArgs ReadArguments()
        {
            _args.Length = Convert.ToInt32(Console.ReadLine());
            _args.Breadth = Convert.ToInt32(Console.ReadLine());
            _args.Height = Convert.ToInt32(Console.ReadLine());
            _args.Weight = Convert.ToInt32(Console.ReadLine());
            return _args;
        }
    }
}
