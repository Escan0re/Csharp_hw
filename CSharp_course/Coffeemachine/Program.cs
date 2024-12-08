using MakeCoffee;

CoffeeMachine coffeeMachine = new CoffeeMachine();

while (true)
{
    Console.WriteLine("Какой кофе пригтовить: 1. Американо 2. Капучино 3. Латте 4. Макиато 5. Мокко");
    if (int.TryParse(Console.ReadLine(), out int coffeeNumber))
    {
        switch (coffeeNumber)
        {
            case 1:
                coffeeMachine.MakeAmericano();
                break;
            case 2:
                coffeeMachine.MakeCappuccino();
                break;
            case 3:
                coffeeMachine.MakeLatte();
                break;
            case 4:
                coffeeMachine.MakeMacchiato();
                break;
            case 5:
                coffeeMachine.MakeMocha();
                break;
            default:
                Console.WriteLine("Ошибка! Неверный выбор.");
                continue;
        }

        break;
    }

    {
        Console.WriteLine("Ошибка! Введите число.");
    }
}