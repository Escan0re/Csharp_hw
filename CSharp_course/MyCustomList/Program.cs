using MyCustomList;

public class Program
{
    static void Main(string[] args)
    {
        MyList list = new MyList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(4, 6);
        list.Add(4, 5);
        list.Add(7);
        list.Add([8, 9, 10]);
        list.Add(3, [4, 4, 4]);


        for (var i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }


    }
}