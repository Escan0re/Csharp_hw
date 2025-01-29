var list = new MyLinkedList();
list.Add(10);
list.Add(20);
list.Add(30);
list.Add(1, 100);
list[2] = 99;

for (var i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}