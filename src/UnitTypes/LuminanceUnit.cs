namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class LuminanceUnit : BaseUnit { 
        private readonly double value;

        public LuminanceUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum LuminanceUnitOfMeasure {
            candelaPerSquareMetre
        }

        public LuminanceUnit(double value, LuminanceUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(LuminanceUnit u) => u.Value;
        public static explicit operator LuminanceUnit(double n) => new LuminanceUnit(n, DefaultUnitOfMeasures.Luminance);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}