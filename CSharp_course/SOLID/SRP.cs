namespace SOLID;

public class Book 
{
    public string Text { get; set; }
    
    // Книга не должна заниматься печатью
    public void Print() 
    {
        Console.WriteLine(Text);
    }
    
    // И не должна управлять файлами
    public void SaveToFile(string path) 
    {
        File.WriteAllText(path, Text);
    }
}

// исправление
public class Book 
{
    public string Text { get; set; }
}

public class Printer 
{
    public void Print(Book book) 
    {
        Console.WriteLine(book.Text);
    }
}

public class BookFileManager 
{
    public void SaveToFile(Book book, string path) 
    {
        File.WriteAllText(path, book.Text);
    }
}