using Coffee;

CoffeeMachine coffeeMachine = new CoffeeMachine();

while (true)
{
    Console.WriteLine("Какой кофе приготовить: 1. Американо 2. Капучино 3. Латте 4. Макиато 5. Мокко");

    if (int.TryParse(Console.ReadLine(), out int userInput) && Enum.IsDefined(typeof(CoffeeType), userInput))
    {
        CoffeeType coffeeType = (CoffeeType)userInput;

        switch (coffeeType)
        {
            case CoffeeType.Americano:
                coffeeMachine.MakeAmericano();
                break;
            case CoffeeType.Cappuccino:
                coffeeMachine.MakeCappuccino();
                break;
            case CoffeeType.Latte:
                coffeeMachine.MakeLatte();
                break;
            case CoffeeType.Macchiato:
                coffeeMachine.MakeMacchiato();
                break;
            case CoffeeType.Mocha:
                coffeeMachine.MakeMocha();
                break;
        }

        Console.WriteLine("Кофе приготовлен!");
        break;
    }

    {
        Console.WriteLine("Ошибка! Введите число от 1 до 5.");
    }
}