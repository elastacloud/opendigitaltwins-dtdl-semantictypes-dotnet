namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes
{
    public abstract class BaseSemanticType<TUnitType> {
        public abstract TUnitType UnitType { get; set; }
    }
}