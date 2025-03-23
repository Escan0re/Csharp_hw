public class Program
{
    public static void Main()
    {
        var dict = new MyDictionary<int, string>();
        dict.Add(1, "One");
        dict.Add(2, "Two");

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}