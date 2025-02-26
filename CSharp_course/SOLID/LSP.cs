namespace SOLID;

// Исправление того, что обсуждали (теперь каждый класс отвечает за свою логику)
public interface IShape
{
    int CalculateArea();
}

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int CalculateArea()
    {
        return Width * Height;
    }
}

public class Square : IShape
{
    public int Size { get; set; }

    public int CalculateArea()
    {
        return Size * Size;
    }
}