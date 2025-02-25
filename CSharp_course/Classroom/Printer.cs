
namespace Classroom;

public class Printer
{
    public void Print(Repository repository)
    {
        int max = repository.Index;

        for (int i = 0; i < max; i++)
        {
            Person temp = repository.GetPersonById(i);
            Console.WriteLine(temp.ToString());
        }
    }
}