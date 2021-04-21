using System;
using Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.UnitTypes;
using Xunit;

namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.Test
{
    public class AccelerationUnitTests
    {
        [Fact]
        public void GivenANumericCast_WhenToStringCalled_AppropriateValue()
        {
            AccelerationUnit au = (AccelerationUnit)167.168d;
            
            var actual = au.ToString();

            Assert.Equal("167.168m/s2", actual);
        }
        [Fact]
        public void GivenANumericCast_WhenNumericCalled_AppropriateValue()
        {
            AccelerationUnit au = (AccelerationUnit)167.168d;
            
            var actual = au.Value;

            Assert.Equal(167.168d, actual);
        }
        [Fact]
        public void GivenANumericCastAndDefaultG_WhenToStringCalled_AppropriateValue()
        {
            DefaultUnitOfMeasures.Acceleration = AccelerationUnit.AccelerationUnitOfMeasure.gForce;
            AccelerationUnit au = (AccelerationUnit)167.168d;
            
            var actual = au.ToString();

            Assert.Equal("167.168G", actual);
        }
    }
}
