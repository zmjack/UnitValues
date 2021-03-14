namespace UnitValues
{
    public partial class UnitValue
    {
        public class PByte : IUnitValue
        {
            public PByte(double value)
            {
                Value = value;
                Postfix = "PB";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator PByte(double value) => new PByte(value);

            public static PByte operator +(PByte obj, Bit other) => new PByte(obj.Value + ((PByte)other).Value);
            public static PByte operator +(PByte obj, Byte other) => new PByte(obj.Value + ((PByte)other).Value);
            public static PByte operator +(PByte obj, KByte other) => new PByte(obj.Value + ((PByte)other).Value);
            public static PByte operator +(PByte obj, MByte other) => new PByte(obj.Value + ((PByte)other).Value);
            public static PByte operator +(PByte obj, GByte other) => new PByte(obj.Value + ((PByte)other).Value);
            public static PByte operator +(PByte obj, TByte other) => new PByte(obj.Value + ((PByte)other).Value);
            public static PByte operator +(PByte obj, PByte other) => new PByte(obj.Value + other.Value);

            public static explicit operator Bit(PByte obj) => new Bit(obj.Value * 9007199254740992);
            public static explicit operator Byte(PByte obj) => new Byte(obj.Value * 1125899906842624);
            public static explicit operator KByte(PByte obj) => new KByte(obj.Value * 1099511627776);
            public static explicit operator MByte(PByte obj) => new MByte(obj.Value * 1073741824);
            public static explicit operator GByte(PByte obj) => new GByte(obj.Value * 1048576);
            public static explicit operator TByte(PByte obj) => new TByte(obj.Value * 1024);
        }
    }
}
