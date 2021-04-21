using System;

namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes
{
    public abstract class BaseUnit
    {
        public virtual string GetUoMString() {
            return string.Empty;
        }
    }
}
