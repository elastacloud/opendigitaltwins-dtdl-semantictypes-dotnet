namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class AreaUnit : BaseUnit { 
        private readonly double value;

        public AreaUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum AreaUnitOfMeasure {
            squareMetre,
            squareCentimetre,
            squareMillimetre,
            squareKilometre,
            hectare,
            squareFoot,
            squareInch,
            acre
        }

        public AreaUnit(double value, AreaUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(AreaUnit u) => u.Value;
        public static explicit operator AreaUnit(double n) => new AreaUnit(n, DefaultUnitOfMeasures.Area);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}