namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class MassFlowRateUnit : BaseUnit {
        private readonly double value;

        public MassFlowRateUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum MassFlowRateUnitOfMeasure {
            gramPerSecond,
            kilogramPerSecond,
            gramPerHour,
            kilogramPerHour
        }

        public MassFlowRateUnit(double value, MassFlowRateUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(MassFlowRateUnit u) => u.Value;
        public static explicit operator MassFlowRateUnit(double n) => new MassFlowRateUnit(n, DefaultUnitOfMeasures.MassFlowRate);

        public override string ToString() => $"{Value}{GetUoMString()}";
     }

}