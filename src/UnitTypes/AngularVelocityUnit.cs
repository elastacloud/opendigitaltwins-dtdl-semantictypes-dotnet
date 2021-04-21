namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class AngularVelocityUnit : BaseUnit { 
        private readonly double value;

        public AngularVelocityUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum AngularVelocityUnitOfMeasure {
            radianPerSecond,
            degreePerSecond,
            revolutionPerSecond,
            revolutionPerMinute
        }

        public AngularVelocityUnit(double value, AngularVelocityUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(AngularVelocityUnit u) => u.Value;
        public static explicit operator AngularVelocityUnit(double n) => new AngularVelocityUnit(n, DefaultUnitOfMeasures.AngularVelocity);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}