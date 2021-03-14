namespace UnitValues
{
    public partial class UnitValue
    {
        public class Bit : IUnitValue
        {
            public Bit(double value)
            {
                Value = value;
                Postfix = "b";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator Bit(double value) => new Bit(value);

            public static Bit operator +(Bit obj, Bit other) => new Bit(obj.Value + other.Value);
            public static Bit operator +(Bit obj, Byte other) => new Bit(obj.Value + ((Bit)other).Value);
            public static Bit operator +(Bit obj, KByte other) => new Bit(obj.Value + ((Bit)other).Value);
            public static Bit operator +(Bit obj, MByte other) => new Bit(obj.Value + ((Bit)other).Value);
            public static Bit operator +(Bit obj, GByte other) => new Bit(obj.Value + ((Bit)other).Value);
            public static Bit operator +(Bit obj, TByte other) => new Bit(obj.Value + ((Bit)other).Value);
            public static Bit operator +(Bit obj, PByte other) => new Bit(obj.Value + ((Bit)other).Value);

            public static explicit operator Byte(Bit obj) => new Byte(obj.Value / 8);
            public static explicit operator KByte(Bit obj) => new KByte(obj.Value / 8192);
            public static explicit operator MByte(Bit obj) => new MByte(obj.Value / 8388608);
            public static explicit operator GByte(Bit obj) => new GByte(obj.Value / 8589934592);
            public static explicit operator TByte(Bit obj) => new TByte(obj.Value / 8796093022208);
            public static explicit operator PByte(Bit obj) => new PByte(obj.Value / 9007199254740992);
        }
    }
}
