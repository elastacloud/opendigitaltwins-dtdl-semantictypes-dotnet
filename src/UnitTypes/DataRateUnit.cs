namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class DataRateUnit : BaseUnit { 
        private readonly double value;

        public DataRateUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum DataRateUnitOfMeasure {
            bitPerSecond,
            kibibitPerSecond,
            mebibitPerSecond,
            gibibitPerSecond,
            tebibitPerSecond,
            exbibitPerSecond,
            zebibitPerSecond,
            yobibitPerSecond,
            bytePerSecond,
            kibibytePerSecond,
            mebibytePerSecond,
            gibibytePerSecond,
            tebibytePerSecond,
            exbibytePerSecond,
            zebibytePerSecond,
            yobibytePerSecond
        }

        public DataRateUnit(double value, DataRateUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(DataRateUnit u) => u.Value;
        public static explicit operator DataRateUnit(double n) => new DataRateUnit(n, DefaultUnitOfMeasures.DataRate);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}