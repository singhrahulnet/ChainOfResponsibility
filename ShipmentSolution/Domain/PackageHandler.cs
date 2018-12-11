using System;
using System.Collections.Generic;
using System.Text;
using ShipmentSolution.Domain;
using ShipmentSolution.Models;

namespace ShipmentSolution.Domain.Handler
{
    public abstract class PackageHandler : IRules, ISize
    {
        protected PackageHandler nextPackage;

        public const int MaxWeight = 25;

        public abstract int Length { get; set; }
        public abstract int Breadth { get; set; }
        public abstract int Height { get; set; }
        
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

        //Let's check if the you can fit in the incoming package
        //Again, the subclasses can handle requirement changes adding their own flavour.
        public virtual bool OverSized(IPackageDimension packageDimension)
        {
            if (packageDimension.Length > Length || packageDimension.Breadth > Breadth || packageDimension.Height > Height)
            {
                return true;
            }
            return false;
        }
        
        //I cannot handle this package. Ask the next one. 
        public void SetNextPackage(PackageHandler next)
        {
            nextPackage = next;
        }
    }
}
