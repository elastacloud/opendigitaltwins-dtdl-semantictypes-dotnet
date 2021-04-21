namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class TemperatureUnit : BaseUnit { 
        private readonly double value;

        public TemperatureUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum TemperatureUnitOfMeasure {
            kelvin,
            degreeCelsius,
            degreeFahrenheit
        }

        public TemperatureUnit(double value, TemperatureUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(TemperatureUnit u) => u.Value;
        public static explicit operator TemperatureUnit(double n) => new TemperatureUnit(n, DefaultUnitOfMeasures.Temperature);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}