namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class LengthUnit : BaseUnit { 
        private readonly double value;

        public LengthUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum LengthUnitOfMeasure {
            	metre,
                centimetre,
                millimetre,
                micrometre,
                nanometre,
                kilometre,
                foot,
                inch,
                mile,
                nauticalMile,
                astronomicalUnit
        }

        public LengthUnit(double value, LengthUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(LengthUnit u) => u.Value;
        public static explicit operator LengthUnit(double n) => new LengthUnit(n, DefaultUnitOfMeasures.Length);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}