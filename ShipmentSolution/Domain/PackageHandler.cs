using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Domain;
using ShipmentSolution.Models;

namespace ShipmentSolution.Domain.Handler
{
    public abstract class PackageHandler : IRules
    {
        protected PackageHandler nextPackage;

        public const int MaxWeight = 25;        

        //I do not know if you are oversized. Find it out yourself if you are inheriting me.
        public abstract bool OverSized(IPackageDimension packageDimension);

        //Incoming package alert! Let me see if I can handle it.
        public virtual void HandlePackage(IPackageDimension dimension)
        {
            if (OverWeight(dimension))
            {
                throw new Exception("Overweight package");
            }
            if (OverSized(dimension))
            {
                nextPackage.HandlePackage(dimension);
            }
        }

        //The absrtact class sets max weight globally 
        //but it can be set at subclass level as well
        public virtual bool OverWeight(IPackageDimension packageDimension)
        {
            return packageDimension.Weight > MaxWeight ? true : false;
        }

        //I cannot handle this package. Ask the next one. 
        public void SetNextPackage(PackageHandler next)
        {
            nextPackage = next;
        }
    }
}
