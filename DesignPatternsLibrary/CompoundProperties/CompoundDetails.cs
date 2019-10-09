using System;

namespace CompoundProperties
{
    class CompoundDetails: Compound
    {
        public CompoundDetails(string compound) : base (compound)
        {
        }

        public override void Display()
        {
            var compoundDatabank = new CompoundDataBank();

            BoilingPoint = compoundDatabank.GetCriticalPoint(Chemical, "B");
            MeltingPoint = compoundDatabank.GetCriticalPoint(Chemical, "M");
            MolecularWeight = compoundDatabank.GetMolecularWeight(Chemical);
            MolecularFormula = compoundDatabank.GetMolecularStructure(Chemical);

            base.Display();
            Console.WriteLine($"Boiling Point: {BoilingPoint}");
            Console.WriteLine($"Melting Point: {MeltingPoint}");
            Console.WriteLine($"Molecular Weight: {MolecularWeight}");
            Console.WriteLine($"Molecular Structure: {MolecularFormula}");
        }

    }
}
