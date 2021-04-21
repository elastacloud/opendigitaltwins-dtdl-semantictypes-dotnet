namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class CapacitanceUnit : BaseUnit {
private readonly double value;

        public CapacitanceUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum CapacitanceUnitOfMeasure {
            farad,
            millifarad,
            microfarad,
            nanofarad,
            picofarad
        }

        public CapacitanceUnit(double value, CapacitanceUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(CapacitanceUnit u) => u.Value;
        public static explicit operator CapacitanceUnit(double n) => new CapacitanceUnit(n, DefaultUnitOfMeasures.Capacitance);

        public override string ToString() => $"{Value}{GetUoMString()}";

     }

}