namespace UnitValues
{
    public partial class UnitValue
    {
        public struct Point : IUnitValue
        {
            public Point(double value)
            {
                Value = value;
                Postfix = "pt";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator Point(double value) => new Point(value);

            public static explicit operator Inch(Point obj) => new Inch(obj.Value / 72);
            public Pixel ToPixel(int dpi = 96) => new Pixel(Value * dpi / 72);
        }
    }
}
