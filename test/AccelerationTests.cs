using Xunit;

namespace Elastacloud.OpenDigitalTwins.Dtdl.SemanticTypes.Test
{
    public class AccelerationTests {
        [Fact]
        public void GivenANumericCast_WhenToStringCalled_AppropriateValue()
        {
            Acceleration a = new Acceleration(167.168d, UnitTypes.AccelerationUnit.AccelerationUnitOfMeasure.metrePerSecondSquared);
            
            var actual = a.ToString();

            Assert.Equal("167.168m/s2", actual);
        }
        [Fact]
        public void GivenANumericCast_WhenNumericCalled_AppropriateValue()
        {
            Acceleration au = (Acceleration)167.168d;
            
            var actual = au.Value;

            Assert.Equal(167.168d, actual);
        }
        [Fact]
        public void GivenANumericCastAndDefaultG_WhenToStringCalled_AppropriateValue()
        {
            DefaultUnitOfMeasures.Acceleration = UnitTypes.AccelerationUnit.AccelerationUnitOfMeasure.gForce;
            Acceleration au = (Acceleration)167.168d;
            
            var actual = au.ToString();

            Assert.Equal("167.168G", actual);
        }
        [Fact]
        public void GivenTwoAccelerations_WhenCompareValue_Equals()
        {
            Acceleration au = (Acceleration)167.168d;
            Acceleration au2 = (Acceleration)167.168d;

            Assert.Equal(au.Value, au2.Value);
        }
        [Fact]
        public void GivenTwoDifferentAccelerations_WhenEquals_NotEquals() {
            Acceleration a1 = new Acceleration(167.168d, UnitTypes.AccelerationUnit.AccelerationUnitOfMeasure.metrePerSecondSquared);

            Acceleration a2 = new Acceleration(167.168d, UnitTypes.AccelerationUnit.AccelerationUnitOfMeasure.gForce);
            
            Assert.NotEqual(a1, a2);
        }
    }
}
