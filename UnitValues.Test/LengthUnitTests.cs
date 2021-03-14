using Xunit;

namespace UnitValues.Test
{
    public class LengthUnitTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(11 / 0.75, LengthUnit.Point(11).ToPixel());
        }

    }
}
