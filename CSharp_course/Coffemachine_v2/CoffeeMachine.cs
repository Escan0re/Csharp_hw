using Coffemachine_v2.CoffeeTypes;

namespace Coffemachine_v2;

public class CoffeeMachine
{
    public Coffee MakeCoffee(CoffeeEnum coffeeType)
    {
        Coffee coffee = null;
        switch (coffeeType)
        {
            case CoffeeEnum.Americano:
                coffee = new Americano();
                coffee.Make();
                break;
            case CoffeeEnum.Cappuccino:
                coffee = new Cappuccino();
                coffee.Make();
                break;
            case CoffeeEnum.Latte:
                coffee = new Latte();
                coffee.Make();
                break;
            case CoffeeEnum.Mokko:
                coffee = new Mokko();
                coffee.Make();
                break;
            case CoffeeEnum.Raf:
                coffee = new Raf();
                coffee.Make();
                break;
        }
        return coffee;
    }
}