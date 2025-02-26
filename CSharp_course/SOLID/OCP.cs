namespace SOLID;

public class AnimalSound 
{
    public string MakeSound(string animalType) 
    {
        return animalType switch
        {
            "Dog" => "Гав!",
            "Cat" => "Мяу!",
            _ => "Неизвестное животное"
        };
    }
    // Чтобы добавить новое животное, нам нужно менять класс, это не ОК.
}

// исправление
public interface IAnimal 
{
    string MakeSound();
}

public class Dog : IAnimal 
{
    public string MakeSound() => "Гав!";
}

public class Cat : IAnimal 
{
    public string MakeSound() => "Мяу!";
}

// Теперь всё ОК. Можно добавлять новые животные без изменения существующего кода