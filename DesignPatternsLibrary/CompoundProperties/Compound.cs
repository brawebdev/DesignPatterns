using System;

namespace CompoundProperties
{
    class Compound
    {
        protected string Chemical;
        protected float BoilingPoint;
        protected float MeltingPoint;
        protected double MolecularWeight;
        protected string MolecularFormula;

        public Compound(string chemical)
        {
            Chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\nCompound: {Chemical}");
        }
    }
}
