namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class ForceUnit : BaseUnit { 
        private readonly double value;

        public ForceUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum ForceUnitOfMeasure {
            newton,
            pound,
            ounce,
            ton
        }

        public ForceUnit(double value, ForceUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(ForceUnit u) => u.Value;
        public static explicit operator ForceUnit(double n) => new ForceUnit(n, DefaultUnitOfMeasures.Force);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}