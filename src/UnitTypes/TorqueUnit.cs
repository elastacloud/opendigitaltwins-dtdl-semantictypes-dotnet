namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class TorqueUnit : BaseUnit { 
        private readonly double value;

        public TorqueUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum TorqueUnitOfMeasure {
            newtonMetre
        }

        public TorqueUnit(double value, TorqueUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(TorqueUnit u) => u.Value;
        public static explicit operator TorqueUnit(double n) => new TorqueUnit(n, DefaultUnitOfMeasures.Torque);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}