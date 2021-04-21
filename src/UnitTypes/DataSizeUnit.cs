namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class DataSizeUnit : BaseUnit { 
        private readonly double value;

        public DataSizeUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum DataSizeUnitOfMeasure {
            	bit,
                kibibit,
                mebibit,
                gibibit,
                tebibit,
                exbibit,
                zebibit,
                yobibit,
                @byte,
                kibibyte,
                mebibyte,
                gibibyte,
                tebibyte,
                exbibyte,
                zebibyte,
                yobibyte
        }

        public DataSizeUnit(double value, DataSizeUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(DataSizeUnit u) => u.Value;
        public static explicit operator DataSizeUnit(double n) => new DataSizeUnit(n, DefaultUnitOfMeasures.DataSize);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}