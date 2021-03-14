using Xunit;

namespace UnitValues.Test
{
    public class StorageUnitTests
    {
        [Fact]
        public void Test1()
        {
            var bit4 = StorageUnit.Bit(4);
            var byte4 = StorageUnit.Byte(4);
            var byte8 = StorageUnit.Byte(8);

            Assert.Equal("12B", (byte4 + byte8).ToString());
            Assert.Equal("36b", (bit4 + byte4).ToString());
            Assert.Equal("4.5B", ((UnitValue.Byte)bit4 + byte4).ToString());
        }
    }
}
