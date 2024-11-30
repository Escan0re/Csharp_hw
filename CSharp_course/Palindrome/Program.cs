Console.WriteLine("Введите число:");
if (int.TryParse(Console.ReadLine(), out var userInput))
{
    Console.WriteLine(IsPalindrome(userInput)
        ? $"Число {userInput} является палиндромом."
        : $"Число {userInput} не является палиндромом.");
}
else
{
    Console.WriteLine("Ошибка: введено не число.");
}

static bool IsPalindrome(int number)
{
    if (number < 0) return false;
    var reversedNumber = 0;
    
    for (var temp = number; temp > 0; temp /= 10)
    {
        var reminder = temp % 10;
        reversedNumber = reversedNumber * 10 + reminder;
    }
    return number == reversedNumber;
}