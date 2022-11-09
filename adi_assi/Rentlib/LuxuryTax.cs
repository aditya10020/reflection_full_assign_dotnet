namespace Rentlib;

[AttributeUsage(AttributeTargets.Class)]
public class LuxuryTax : Attribute
{

    public int Limit {get; set;}

    public LuxuryTax(int value = 8)
    {
        Limit = value;
    }

}