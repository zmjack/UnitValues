namespace UnitValues
{
    public partial class UnitValue
    {
        public class GByte : IUnitValue
        {
            public GByte(double value)
            {
                Value = value;
                Postfix = "GB";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator GByte(double value) => new GByte(value);

            public static GByte operator +(GByte obj, Bit other) => new GByte(obj.Value + ((GByte)other).Value);
            public static GByte operator +(GByte obj, Byte other) => new GByte(obj.Value + ((GByte)other).Value);
            public static GByte operator +(GByte obj, KByte other) => new GByte(obj.Value + ((GByte)other).Value);
            public static GByte operator +(GByte obj, MByte other) => new GByte(obj.Value + ((GByte)other).Value);
            public static GByte operator +(GByte obj, GByte other) => new GByte(obj.Value + other.Value);
            public static GByte operator +(GByte obj, TByte other) => new GByte(obj.Value + ((GByte)other).Value);
            public static GByte operator +(GByte obj, PByte other) => new GByte(obj.Value + ((GByte)other).Value);

            public static explicit operator Bit(GByte obj) => new Bit(obj.Value * 8589934592);
            public static explicit operator Byte(GByte obj) => new Byte(obj.Value * 1073741824);
            public static explicit operator KByte(GByte obj) => new KByte(obj.Value * 1048576);
            public static explicit operator MByte(GByte obj) => new MByte(obj.Value * 1024);
            public static explicit operator TByte(GByte obj) => new TByte(obj.Value / 1024);
            public static explicit operator PByte(GByte obj) => new PByte(obj.Value / 1048576);
        }
    }
}
