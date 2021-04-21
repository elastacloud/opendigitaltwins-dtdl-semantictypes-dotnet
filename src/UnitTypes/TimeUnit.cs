namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class TimeUnit : BaseUnit { 
        private readonly double value;

        public TimeUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum TimeUnitOfMeasure {
            second,
            millisecond,
            microsecond,
            nanosecond,
            minute,
            hour,
            day,
            year
        }

        public TimeUnit(double value, TimeUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(TimeUnit u) => u.Value;
        public static explicit operator TimeUnit(double n) => new TimeUnit(n, DefaultUnitOfMeasures.Time);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}