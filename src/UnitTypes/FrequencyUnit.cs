namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class FrequencyUnit : BaseUnit { 
        private readonly double value;

        public FrequencyUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum FrequencyUnitOfMeasure {
            hertz,
            kilohertz,
            megahertz,
            gigahertz
        }

        public FrequencyUnit(double value, FrequencyUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(FrequencyUnit u) => u.Value;
        public static explicit operator FrequencyUnit(double n) => new FrequencyUnit(n, DefaultUnitOfMeasures.Frequency);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}