using ShipmentSolution.Models;

namespace ShipmentSolution.Domain.Handler
{
    public abstract class PackageHandler : IRules
    {
        protected PackageHandler nextPackage;

        public const int MaxWeight = 25;

        //Each subclass needs to provide its L,B,H and the cost
        public abstract int Length { get; }
        public abstract int Breadth { get; }
        public abstract int Height { get; }
        public abstract int Cost { get; }
        


        //Incoming package alert! Let me see if I can handle it.
        public virtual void HandlePackage(IArgs dimension, ref IResult result)
        {
            if (OverWeight(dimension))
            {
                result = new Result { FinalCost = 0, PackageType = "Overweight!!" };
            }
            else if (OverSized(dimension))
            {
                //Cannot handle it. Passing it to a bigger guy
                if (nextPackage != null) nextPackage.HandlePackage(dimension, ref result);
            }
            else
            {
                result = new Result { FinalCost = this.Cost, PackageType = this.ToString() };
            }
        }

        //The absrtact class sets max weight globally but it can be set at subclass level as well
        public virtual bool OverWeight(IArgs packageDimension)
        {
            return packageDimension.Weight > MaxWeight;
        }

        //Can I fit it in? Again, the subclasses can handle requirement changes by adding their own flavour.
        public virtual bool OverSized(IArgs packageDimension)
        {
            return
                //Compare as is
                (packageDimension.Length > Length
                || packageDimension.Breadth > Breadth
                || packageDimension.Height > Height
                );

            /*OR
            what if we try to fit the package Breadth-wise? It can still fit in, right?
            Implement if needed */
        }

        //I cannot handle this package. Ask the next one. 
        public void SetNextPackage(PackageHandler next)
        {
            nextPackage = next;
        }
    }
}
