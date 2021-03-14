namespace UnitValues
{
    public static class LengthUnit
    {
        public static UnitValue.Point Point(double value) => new UnitValue.Point(value);
        public static UnitValue.Pixel Pixel(double value) => new UnitValue.Pixel(value);
    }
}
