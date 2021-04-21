namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class PressureUnit : BaseUnit { 
        private readonly double value;

        public PressureUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum PressureUnitOfMeasure {
            pascal,
            kilopascal,
            bar,
            millibar,
            millimetresOfMercury,
            poundPerSquareInch,
            inchesOfMercury,
            inchesOfWater
        }

        public PressureUnit(double value, PressureUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(PressureUnit u) => u.Value;
        public static explicit operator PressureUnit(double n) => new PressureUnit(n, DefaultUnitOfMeasures.Pressure);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}