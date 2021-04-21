namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class DensityUnit : BaseUnit { 
        private readonly double value;

        public DensityUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum DensityUnitOfMeasure {
            kilogramPerCubicMetre,
            gramPerCubicMetre
        }

        public DensityUnit(double value, DensityUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(DensityUnit u) => u.Value;
        public static explicit operator DensityUnit(double n) => new DensityUnit(n, DefaultUnitOfMeasures.Density);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}