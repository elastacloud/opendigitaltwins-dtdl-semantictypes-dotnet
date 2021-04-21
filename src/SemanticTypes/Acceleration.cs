using Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes;
using static Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes.AccelerationUnit;

namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes
{

    public class Acceleration : BaseSemanticType<AccelerationUnit> {
        public override AccelerationUnit UnitType { get; set; }

        public Acceleration(double value, AccelerationUnitOfMeasure aUoM)
        {
            UnitType = new AccelerationUnit(value, aUoM);
        }
        public double Value => UnitType.Value;
        public override string ToString() => UnitType.ToString();        
        
        public static implicit operator double(Acceleration u) => u.Value;
        public static explicit operator Acceleration(double n) => new Acceleration(n, DefaultUnitOfMeasures.Acceleration);

        public override bool Equals(object obj)
        {
            return obj is Acceleration a 
                && a.UnitType.UoM == this.UnitType.UoM 
                && a.Value == this.Value;
        }
    }
}