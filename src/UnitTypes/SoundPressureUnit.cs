namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class SoundPressureUnit : BaseUnit { 
        private readonly double value;

        public SoundPressureUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum SoundPressureUnitOfMeasure {
            decibel,
            bel
        }

        public SoundPressureUnit(double value, SoundPressureUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(SoundPressureUnit u) => u.Value;
        public static explicit operator SoundPressureUnit(double n) => new SoundPressureUnit(n, DefaultUnitOfMeasures.SoundPressure);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}