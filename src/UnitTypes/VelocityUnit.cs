namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class VelocityUnit : BaseUnit { 
        private readonly double value;

        public VelocityUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum VelocityUnitOfMeasure {
            metrePerSecond,
            centimetrePerSecond,
            kilometrePerSecond,
            metrePerHour,
            kilometrePerHour,
            milePerHour,
            milePerSecond,
            knot
        }

        public VelocityUnit(double value, VelocityUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(VelocityUnit u) => u.Value;
        public static explicit operator VelocityUnit(double n) => new VelocityUnit(n, DefaultUnitOfMeasures.Velocity);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}