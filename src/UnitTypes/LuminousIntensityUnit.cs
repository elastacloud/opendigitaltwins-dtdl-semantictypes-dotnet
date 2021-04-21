namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class LuminousIntensityUnit : BaseUnit { 
        private readonly double value;

        public LuminousIntensityUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum LuminousIntensityUnitOfMeasure {
            metrePerSecondSquared,
            centimetrePerSecondSquared,
            gForce
        }

        public LuminousIntensityUnit(double value, LuminousIntensityUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(LuminousIntensityUnit u) => u.Value;
        public static explicit operator LuminousIntensityUnit(double n) => new LuminousIntensityUnit(n, DefaultUnitOfMeasures.LuminousIntensity);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}