Console.WriteLine("Введите сумму счета:");
var billAmount = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите процент чаевых:");
var tipPercentage = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите количество человек в группе:");
var numberOfPeople = int.Parse(Console.ReadLine());

var totalAmount = billAmount + billAmount * tipPercentage / 100;
var amountPerPerson = totalAmount / numberOfPeople;

Console.WriteLine($"Общий счет: {totalAmount}");
Console.WriteLine($"Процент чаевых {tipPercentage}%");
Console.WriteLine($"С каждого: {amountPerPerson}");
