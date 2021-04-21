namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class AngleUnit : BaseUnit {
        private readonly double value;

        public AngleUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum AngleUnitOfMeasure {
            radian,
            degreeOfArc,
            minuteOfArc,
            secondOfArc,
            turn
        }

        public AngleUnit(double value, AngleUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(AngleUnit u) => u.Value;
        public static explicit operator AngleUnit(double n) => new AngleUnit(n, DefaultUnitOfMeasures.Angle);

        public override string ToString() => $"{Value}{GetUoMString()}";

     }

}