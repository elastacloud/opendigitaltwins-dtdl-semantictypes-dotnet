namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class ResistanceUnit : BaseUnit { 
        private readonly double value;

        public ResistanceUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum ResistanceUnitOfMeasure {
            ohm,
            milliohm,
            kiloohm,
            megaohm
        }

        public ResistanceUnit(double value, ResistanceUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(ResistanceUnit u) => u.Value;
        public static explicit operator ResistanceUnit(double n) => new ResistanceUnit(n, DefaultUnitOfMeasures.Resistance);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}