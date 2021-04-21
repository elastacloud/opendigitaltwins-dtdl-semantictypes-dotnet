namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class CurrentUnit : BaseUnit {
        private readonly double value;

        public CurrentUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum CurrentUnitOfMeasure {
            ampere,
            microampere,
            milliampere
        }

        public CurrentUnit(double value, CurrentUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(CurrentUnit u) => u.Value;
        public static explicit operator CurrentUnit(double n) => new CurrentUnit(n, DefaultUnitOfMeasures.Current);

        public override string ToString() => $"{Value}{GetUoMString()}";
     }

}