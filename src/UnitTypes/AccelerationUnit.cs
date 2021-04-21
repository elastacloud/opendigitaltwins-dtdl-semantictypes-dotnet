namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class AccelerationUnit : BaseUnit {        
        private readonly double value;

        public AccelerationUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum AccelerationUnitOfMeasure {
            metrePerSecondSquared,
            centimetrePerSecondSquared,
            gForce
        }

        public AccelerationUnit(double value, AccelerationUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(AccelerationUnit u) => u.Value;
        public static explicit operator AccelerationUnit(double n) => new AccelerationUnit(n, DefaultUnitOfMeasures.Acceleration);

        public override string ToString() => $"{Value}{GetUoMString()}";
        public override string GetUoMString() {
            switch (UoM)
            {
                case AccelerationUnitOfMeasure.centimetrePerSecondSquared:
                    return "cm/s2";
                case AccelerationUnitOfMeasure.gForce:
                    return "G";
                case AccelerationUnitOfMeasure.metrePerSecondSquared:
                default:
                    return "m/s2";
            }
        }
    }
    public class unitless : BaseUnit { }

}