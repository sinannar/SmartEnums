namespace SmartApproach;

public class CreditCard : Enumeration<CreditCard>
{
    public static readonly CreditCard Standard = new(1, nameof(Standard));
    public static readonly CreditCard Premium = new(2, nameof(Premium));
    public static readonly CreditCard Platinium = new(3, nameof(Platinium));

    private CreditCard(int value, string name) : base(value, name)
    {

    }

    public double Discount => 0.0;
}