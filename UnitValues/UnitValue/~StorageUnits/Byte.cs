namespace UnitValues
{
    public partial class UnitValue
    {
        public class Byte : IUnitValue
        {
            public Byte(double value)
            {
                Value = value;
                Postfix = "B";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator Byte(double value) => new Byte(value);

            public static Byte operator +(Byte obj, Bit other) => new Byte(obj.Value + ((Byte)other).Value);
            public static Byte operator +(Byte obj, Byte other) => new Byte(obj.Value + other.Value);
            public static Byte operator +(Byte obj, KByte other) => new Byte(obj.Value + ((Byte)other).Value);
            public static Byte operator +(Byte obj, MByte other) => new Byte(obj.Value + ((Byte)other).Value);
            public static Byte operator +(Byte obj, GByte other) => new Byte(obj.Value + ((Byte)other).Value);
            public static Byte operator +(Byte obj, TByte other) => new Byte(obj.Value + ((Byte)other).Value);
            public static Byte operator +(Byte obj, PByte other) => new Byte(obj.Value + ((Byte)other).Value);

            public static explicit operator Bit(Byte obj) => new Bit(obj.Value * 8);
            public static explicit operator KByte(Byte obj) => new KByte(obj.Value / 1024);
            public static explicit operator MByte(Byte obj) => new MByte(obj.Value / 1048576);
            public static explicit operator GByte(Byte obj) => new GByte(obj.Value / 1073741824);
            public static explicit operator TByte(Byte obj) => new TByte(obj.Value / 1099511627776);
            public static explicit operator PByte(Byte obj) => new PByte(obj.Value / 1125899906842624);
        }
    }
}
