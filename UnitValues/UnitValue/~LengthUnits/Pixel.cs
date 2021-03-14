namespace UnitValues
{
    public partial class UnitValue
    {
        public struct Pixel : IUnitValue
        {
            public Pixel(double value)
            {
                Value = value;
                Postfix = "px";
            }

            public double Value { get; set; }
            public string Postfix { get; }
            public override string ToString() => $"{Value}{Postfix}";

            public static implicit operator Pixel(double value) => new Pixel(value);

            public Inch ToInch(int dpi = 96) => new Inch(Value / dpi);
            public Point ToPoint(int dpi = 96) => new Point(Value * 72 / dpi);
        }
    }
}
