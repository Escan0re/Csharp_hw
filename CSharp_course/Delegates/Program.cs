//Задание 1

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

Action<string> message = PrintMessage;
message("Hello World!");

//Задание2
int Sum(int a, int b)
{
    return a + b;
}

Func<int, int, int> func = Sum;
var result = func(10, 20);
Console.WriteLine(result);

//Задание 3
void PrintNumbers(int[] numbers)
{
    foreach (var num in numbers)
    {
        Console.WriteLine(num);
    }
}

Action<int[]> action = PrintNumbers;
int[] array = { 1, 2, 3 };
action(array);

//Задание 4

int Factorial(int n)
{
    return n > 1 ? n * Factorial(n - 1) : 1;
}

Func<int, int> func1 = Factorial;
var result1 = func1(2);
Console.WriteLine(result1);

//Задание 5
int Multiply(int a, int b)
{
    return a * b;
}

void PrintResult(int result)
{
    Console.WriteLine(result);
}

Func<int, int, int> func2 = Multiply;
Action<int> printAction = PrintResult;

var result2 = func2(5, 6);
printAction(result2);