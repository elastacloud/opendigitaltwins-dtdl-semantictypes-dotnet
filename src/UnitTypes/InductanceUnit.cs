namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class InductanceUnit : BaseUnit {
        private readonly double value;

        public InductanceUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum InductanceUnitOfMeasure {
            henry,
            millihenry,
            microhenry
        }

        public InductanceUnit(double value, InductanceUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(InductanceUnit u) => u.Value;
        public static explicit operator InductanceUnit(double n) => new InductanceUnit(n, DefaultUnitOfMeasures.Inductance);

        public override string ToString() => $"{Value}{GetUoMString()}";
     }

}