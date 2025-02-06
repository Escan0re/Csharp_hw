var userScore = 0;
Console.WriteLine("Что означает слово 'cat'?");
var answer = Console.ReadLine();
if (answer == "кошка")
{
    userScore += 10;
    Console.WriteLine("Всё верно!");
}
else
{
    Console.WriteLine("Нужно подумать ещё...");
}
Console.WriteLine("Что означает слово 'dog'?");
var answer1 = Console.ReadLine();
if (answer1 == "собака")
{
    userScore += 10;
    Console.WriteLine("Всё верно!");
}
else
{
    Console.WriteLine("Нужно подумать ещё...");
}
Console.WriteLine(userScore);