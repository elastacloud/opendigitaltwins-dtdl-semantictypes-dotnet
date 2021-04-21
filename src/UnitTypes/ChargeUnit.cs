namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class ChargeUnit : BaseUnit { 
        private readonly double value;

        public ChargeUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum ChargeUnitOfMeasure {
            coulomb
        }

        public ChargeUnit(double value, ChargeUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(ChargeUnit u) => u.Value;
        public static explicit operator ChargeUnit(double n) => new ChargeUnit(n, DefaultUnitOfMeasures.Charge);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}