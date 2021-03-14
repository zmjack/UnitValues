namespace UnitValues
{
    public partial class UnitValue
    {
        public class TByte : IUnitValue
        {
            public TByte(double value)
            {
                Value = value;
                Postfix = "TB";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator TByte(double value) => new TByte(value);

            public static TByte operator +(TByte obj, Bit other) => new TByte(obj.Value + ((TByte)other).Value);
            public static TByte operator +(TByte obj, Byte other) => new TByte(obj.Value + ((TByte)other).Value);
            public static TByte operator +(TByte obj, KByte other) => new TByte(obj.Value + ((TByte)other).Value);
            public static TByte operator +(TByte obj, MByte other) => new TByte(obj.Value + ((TByte)other).Value);
            public static TByte operator +(TByte obj, GByte other) => new TByte(obj.Value + ((TByte)other).Value);
            public static TByte operator +(TByte obj, TByte other) => new TByte(obj.Value + other.Value);
            public static TByte operator +(TByte obj, PByte other) => new TByte(obj.Value + ((TByte)other).Value);

            public static explicit operator Bit(TByte obj) => new Bit(obj.Value * 8796093022208);
            public static explicit operator Byte(TByte obj) => new Byte(obj.Value * 1099511627776);
            public static explicit operator KByte(TByte obj) => new KByte(obj.Value * 1073741824);
            public static explicit operator MByte(TByte obj) => new MByte(obj.Value * 1048576);
            public static explicit operator GByte(TByte obj) => new GByte(obj.Value * 1024);
            public static explicit operator PByte(TByte obj) => new PByte(obj.Value / 1024);
        }
    }
}
