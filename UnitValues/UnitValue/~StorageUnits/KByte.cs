namespace UnitValues
{
    public partial class UnitValue
    {
        public class KByte : IUnitValue
        {
            public KByte(double value)
            {
                Value = value;
                Postfix = "KB";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator KByte(double value) => new KByte(value);

            public static KByte operator +(KByte obj, Bit other) => new KByte(obj.Value + ((KByte)other).Value);
            public static KByte operator +(KByte obj, Byte other) => new KByte(obj.Value + ((KByte)other).Value);
            public static KByte operator +(KByte obj, KByte other) => new KByte(obj.Value + other.Value);
            public static KByte operator +(KByte obj, MByte other) => new KByte(obj.Value + ((KByte)other).Value);
            public static KByte operator +(KByte obj, GByte other) => new KByte(obj.Value + ((KByte)other).Value);
            public static KByte operator +(KByte obj, TByte other) => new KByte(obj.Value + ((KByte)other).Value);
            public static KByte operator +(KByte obj, PByte other) => new KByte(obj.Value + ((KByte)other).Value);

            public static explicit operator Bit(KByte obj) => new Bit(obj.Value * 8192);
            public static explicit operator Byte(KByte obj) => new Byte(obj.Value * 1024);
            public static explicit operator MByte(KByte obj) => new MByte(obj.Value / 1024);
            public static explicit operator GByte(KByte obj) => new GByte(obj.Value / 1048576);
            public static explicit operator TByte(KByte obj) => new TByte(obj.Value / 1073741824);
            public static explicit operator PByte(KByte obj) => new PByte(obj.Value / 1099511627776);
        }
    }
}
