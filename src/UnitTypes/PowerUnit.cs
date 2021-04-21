namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class PowerUnit : BaseUnit {
        private readonly double value;

        public PowerUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum PowerUnitOfMeasure {
            watt,
            microwatt,
            milliwatt,
            kilowatt,
            megawatt,
            gigawatt,
            horsepower,
            kilowattHourPerYear
        }

        public PowerUnit(double value, PowerUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(PowerUnit u) => u.Value;
        public static explicit operator PowerUnit(double n) => new PowerUnit(n, DefaultUnitOfMeasures.PowerUnit);

        public override string ToString() => $"{Value}{GetUoMString()}";
     }

}