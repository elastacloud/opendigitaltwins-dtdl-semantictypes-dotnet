namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class VoltageUnit : BaseUnit {
        private readonly double value;

        public VoltageUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum VoltageUnitOfMeasure {
            volt,
            millivolt,
            microvolt,
            kilovolt,
            megavolt
        }

        public VoltageUnit(double value, VoltageUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(VoltageUnit u) => u.Value;
        public static explicit operator VoltageUnit(double n) => new VoltageUnit(n, DefaultUnitOfMeasures.Voltage);

        public override string ToString() => $"{Value}{GetUoMString()}";
     }

}