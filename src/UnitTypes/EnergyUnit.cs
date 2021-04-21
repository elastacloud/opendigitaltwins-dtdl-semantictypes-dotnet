namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class EnergyUnit : BaseUnit { 
        private readonly double value;

        public EnergyUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum EnergyUnitOfMeasure {
            joule,
            kilojoule,
            megajoule,
            gigajoule,
            electronvolt,
            megaelectronvolt,
            kilowattHour
        }

        public EnergyUnit(double value, EnergyUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(EnergyUnit u) => u.Value;
        public static explicit operator EnergyUnit(double n) => new EnergyUnit(n, DefaultUnitOfMeasures.Energy);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}