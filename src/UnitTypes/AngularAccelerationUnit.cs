namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class AngularAccelerationUnit : BaseUnit { 
        private readonly double value;

        public AngularAccelerationUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum AngularAccelerationUnitOfMeasure {
            radianPerSecondSquared
        }

        public AngularAccelerationUnit(double value, AngularAccelerationUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(AngularAccelerationUnit u) => u.Value;
        public static explicit operator AngularAccelerationUnit(double n) => new AngularAccelerationUnit(n, DefaultUnitOfMeasures.AngularAcceleration);

        public override string ToString() => $"{Value}{GetUoMString()}";

    }

}