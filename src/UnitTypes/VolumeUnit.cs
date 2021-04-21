namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes
{
    public class VolumeUnit : BaseUnit {
        private readonly double value;

        public VolumeUnitOfMeasure UoM { get; }

        public double Value => value;

        public enum VolumeUnitOfMeasure {
            cubicMetre,
            cubicCentimetre,
            litre,
            millilitre,
            cubicFoot,
            cubicInch,
            fluidOunce,
            gallon
        }

        public VolumeUnit(double value, VolumeUnitOfMeasure aUoM)
        {
            this.value = value;
            UoM = aUoM;
        }       

        public static implicit operator double(VolumeUnit u) => u.Value;
        public static explicit operator VolumeUnit(double n) => new VolumeUnit(n, DefaultUnitOfMeasures.Volume);

        public override string ToString() => $"{Value}{GetUoMString()}";
     }

}