namespace UnitValues
{
    public partial class UnitValue
    {
        public class MByte : IUnitValue
        {
            public MByte(double value)
            {
                Value = value;
                Postfix = "MB";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator MByte(double value) => new MByte(value);

            public static MByte operator +(MByte obj, Bit other) => new MByte(obj.Value + ((MByte)other).Value);
            public static MByte operator +(MByte obj, Byte other) => new MByte(obj.Value + ((MByte)other).Value);
            public static MByte operator +(MByte obj, KByte other) => new MByte(obj.Value + ((MByte)other).Value);
            public static MByte operator +(MByte obj, MByte other) => new MByte(obj.Value + other.Value);
            public static MByte operator +(MByte obj, GByte other) => new MByte(obj.Value + ((MByte)other).Value);
            public static MByte operator +(MByte obj, TByte other) => new MByte(obj.Value + ((MByte)other).Value);
            public static MByte operator +(MByte obj, PByte other) => new MByte(obj.Value + ((MByte)other).Value);

            public static explicit operator Bit(MByte obj) => new Bit(obj.Value * 8388608);
            public static explicit operator Byte(MByte obj) => new Byte(obj.Value * 1048576);
            public static explicit operator KByte(MByte obj) => new KByte(obj.Value * 1024);
            public static explicit operator GByte(MByte obj) => new GByte(obj.Value / 1024);
            public static explicit operator TByte(MByte obj) => new TByte(obj.Value / 1048576);
            public static explicit operator PByte(MByte obj) => new PByte(obj.Value / 1073741824);
        }
    }
}
