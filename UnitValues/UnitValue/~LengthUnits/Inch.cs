namespace UnitValues
{
    public partial class UnitValue
    {
        public struct Inch : IUnitValue
        {
            public Inch(double value)
            {
                Value = value;
                Postfix = "inch";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator Inch(double value) => new Inch(value);

            public static explicit operator Point(Inch obj) => new Point(obj.Value * 72);
            public Pixel ToPixel(int dpi = 96) => new Pixel(Value * dpi);
        }
    }
}
