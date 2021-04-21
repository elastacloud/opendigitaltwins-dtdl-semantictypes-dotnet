namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class IlluminanceUnit : BaseUnit { 
        private readonly double value;

        public IlluminanceUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum IlluminanceUnitOfMeasure {
            lux,
            footcandle
        }

        public IlluminanceUnit(double value, IlluminanceUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(IlluminanceUnit u) => u.Value;
        public static explicit operator IlluminanceUnit(double n) => new IlluminanceUnit(n, DefaultUnitOfMeasures.Illuminance);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}