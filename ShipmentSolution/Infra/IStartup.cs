using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentSolution.Infra
{
    public interface IStartup
    {
        //Set up chain of responsibility
        void SetChain();
    }
}
