namespace SmartApproach;

public abstract class CreditCard : Enumeration<CreditCard>
{
    public static readonly CreditCard Standard = new StandardCreditCard();
    public static readonly CreditCard Premium = new PremiumCreditCard();
    public static readonly CreditCard Platinium = new PlatiniumCreditCard();

    protected CreditCard(int value, string name) : base(value, name)
    {

    }

    public abstract double Discount { get; }

    private sealed class StandardCreditCard : CreditCard
    {
        public StandardCreditCard() : base(1, "Standard")
        {            
        }

        public override double Discount => 0.1;
    }

    private sealed class PremiumCreditCard : CreditCard
    {
        public PremiumCreditCard() : base(2, "Premium")
        {            
        }

        public override double Discount => 0.2;
    }

    private sealed class PlatiniumCreditCard : CreditCard
    {
        public PlatiniumCreditCard() : base(3, "Platinium")
        {            
        }

        public override double Discount => 0.3;
    }
}