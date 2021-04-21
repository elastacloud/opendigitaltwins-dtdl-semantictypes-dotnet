namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class VolumeFlowRateUnit : BaseUnit { 
        private readonly double value;

        public VolumeFlowRateUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum VolumeFlowRateUnitOfMeasure {
            litrePerSecond,
            millilitrePerSecond,
            litrePerHour,
            millilitrePerHour
        }

        public VolumeFlowRateUnit(double value, VolumeFlowRateUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(VolumeFlowRateUnit u) => u.Value;
        public static explicit operator VolumeFlowRateUnit(double n) => new VolumeFlowRateUnit(n, DefaultUnitOfMeasures.VolumeFlowRate);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}