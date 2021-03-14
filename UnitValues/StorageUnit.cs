namespace UnitValues
{
    public static class StorageUnit
    {
        public static UnitValue.Bit Bit(double value) => new UnitValue.Bit(value);
        public static UnitValue.Byte Byte(double value) => new UnitValue.Byte(value);
        public static UnitValue.KByte KByte(double value) => new UnitValue.KByte(value);
        public static UnitValue.MByte MByte(double value) => new UnitValue.MByte(value);
        public static UnitValue.GByte GByte(double value) => new UnitValue.GByte(value);
        public static UnitValue.TByte TByte(double value) => new UnitValue.TByte(value);
        public static UnitValue.PByte PByte(double value) => new UnitValue.PByte(value);
    }
}
