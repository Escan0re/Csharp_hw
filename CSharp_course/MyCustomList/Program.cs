using MyCustomList;

var list = new MyList<int>();

list.Add(1);
list.Add(2);
list.Add(3);

list.Add([7, 8, 9]);
list.Add(1, 999);
list.Add(3, [1000, 2000, 3000]);

for (var i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

Console.WriteLine("Count: " + list.Count);
Console.WriteLine("Capacity: " + list.Capacity);

Console.WriteLine("------------ сортировка ------------");

list.Sort();
for (var i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}