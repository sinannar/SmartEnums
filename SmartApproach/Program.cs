using SmartApproach;

var card_p = CreditCard.FromValue(3);
var card_pp = CreditCard.FromName("Platinium");

var card1 = CreditCard.Platinium;
var card2 = CreditCard.Premium;
var card3 = CreditCard.Standard;

Console.WriteLine($"Discount for {card_p} is {card_p.Discount:P}");
Console.WriteLine($"Discount for {card_pp} is {card_pp.Discount:P}");

Console.WriteLine($"Discount for {card1} is {card1.Discount:P}");
Console.WriteLine($"Discount for {card2} is {card2.Discount:P}");
Console.WriteLine($"Discount for {card3} is {card3.Discount:P}");