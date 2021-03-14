namespace UnitValues
{
    public interface IUnitValue
    {
        double Value { get; set; }
        string Postfix { get; }
    }
}
