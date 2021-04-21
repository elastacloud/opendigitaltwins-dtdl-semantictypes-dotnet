namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class LuminousFluxUnit : BaseUnit { 
        private readonly double value;

        public LuminousFluxUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum LuminousFluxUnitOfMeasure {
            lumen
        }

        public LuminousFluxUnit(double value, LuminousFluxUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(LuminousFluxUnit u) => u.Value;
        public static explicit operator LuminousFluxUnit(double n) => new LuminousFluxUnit(n, DefaultUnitOfMeasures.LuminousFlux);

        public override string ToString() => $"{Value}{GetUoMString()}";
    }

}