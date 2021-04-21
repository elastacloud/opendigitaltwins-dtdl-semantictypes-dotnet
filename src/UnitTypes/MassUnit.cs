namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class MassUnit : BaseUnit { 
        private readonly double value;

        public MassUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum MassUnitOfMeasure {
            kilogram,
            gram,
            milligram,
            microgram,
            tonne,
            slug
        }

        public MassUnit(double value, MassUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(MassUnit u) => u.Value;
        public static explicit operator MassUnit(double n) => new MassUnit(n, DefaultUnitOfMeasures.Mass);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}