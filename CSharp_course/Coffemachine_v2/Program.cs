using Coffemachine_v2;

Console.WriteLine("1. Американо 2. Капучино 3. Латте 4. Мокко 5. Раф");
bool isValidInput = int.TryParse(Console.ReadLine(), out var userInput);

if (!isValidInput || userInput < 1 || userInput > 5)
{
    Console.WriteLine("Ошибка: Пожалуйста, введите число от 1 до 5.");
    return;
}
var coffeeType = (CoffeeEnum)userInput;

var coffeeMachine = new CoffeeMachine();

var coffee = coffeeMachine.MakeCoffee(coffeeType);
