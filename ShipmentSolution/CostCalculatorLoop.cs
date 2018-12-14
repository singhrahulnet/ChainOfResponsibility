using ShipmentSolution.Domain;
using ShipmentSolution.Infra;
using ShipmentSolution.IOService;
using ShipmentSolution.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentSolution
{
    interface ICostCalculatorLoop
    {
        void Run();
    }
    class CostCalculatorLoop : ICostCalculatorLoop
    {
        private IOutputService _outputService;
        private IInputService _inputService;
        private IResult _result;
        private IPackageInventory _packageInventory;

        public CostCalculatorLoop(IOutputService outputService,
                                 IInputService inputService,
                                 IResult result,
                                 IPackageInventory packageInventory)
        {
            _outputService = outputService;
            _inputService = inputService;
            _result = result;
            _packageInventory = packageInventory;
        }

        public void Run()
        {
            _outputService.WriteInitMessage();

            while (true)
            {
                _result.PackageType = "Not found!!";
                IArgs dimension = _inputService.ReadArguments();                
                _packageInventory.SmallestPackage.HandlePackage(dimension, ref _result);
                _outputService.WriteResultMessage(_result);
            }
        }
    }
}
