namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class MagneticInductionUnit : BaseUnit { 
        private readonly double value;

        public MagneticInductionUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum MagneticInductionUnitOfMeasure {
            tesla
        }

        public MagneticInductionUnit(double value, MagneticInductionUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(MagneticInductionUnit u) => u.Value;
        public static explicit operator MagneticInductionUnit(double n) => new MagneticInductionUnit(n, DefaultUnitOfMeasures.MagneticInduction);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}