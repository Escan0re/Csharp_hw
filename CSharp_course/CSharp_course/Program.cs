Console.WriteLine("Введите номер команды для игрока 1 (1 - Камень, 2 - Ножницы, 3 - Бумага):");
if (!int.TryParse(Console.ReadLine(), out int player1) || player1 < 1 || player1 > 3)
{
    Console.WriteLine("Ошибка: Введите корректное число от 1 до 3 для игрока 1.");
    return;
}

Console.WriteLine("Введите номер команды для игрока 2 (1 - Камень, 2 - Ножницы, 3 - Бумага):");
if (!int.TryParse(Console.ReadLine(), out int player2) || player2 < 1 || player2 > 3)
{
    Console.WriteLine("Ошибка: Введите корректное число от 1 до 3 для игрока 2.");
    return;
}

if (player1 == player2)
{
    Console.WriteLine("Ничья.");
}
else if (player1 == 1 && player2 == 2 || player1 == 2 && player2 == 3 || player1 == 3 && player2 == 1)
{
    Console.WriteLine("Победил 1й игрок.");
}
else
{
    Console.WriteLine("Победил 2й игрок.");
}


