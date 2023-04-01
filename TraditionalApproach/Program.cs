using TraditionalApproach;

var card = CreditCard.Platinium;

var discount = card switch 
{
    CreditCard.Standard => 0.1,
    CreditCard.Premium => 0.2,
    CreditCard.Platinium => 0.3,
};

Console.WriteLine($"Discount for {card} is {discount:P}");