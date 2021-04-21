namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class MagneticFluxUnit : BaseUnit { 
        private readonly double value;

        public MagneticFluxUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum MagneticFluxUnitOfMeasure {
            weber,
            maxwell
        }

        public MagneticFluxUnit(double value, MagneticFluxUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(MagneticFluxUnit u) => u.Value;
        public static explicit operator MagneticFluxUnit(double n) => new MagneticFluxUnit(n, DefaultUnitOfMeasures.MagneticFlux);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}