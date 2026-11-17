interface IFigure
{
    IFigure Clone();
    void GetInfo();
}

class Rectangle(int w, int h) : IFigure
{
    public IFigure Clone()
    {
        return new Rectangle(w, h);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Прямокутник довжиною {h} и шириною {w}");
    }
}

class Circle(int r) : IFigure
{
    public IFigure Clone()
    {
        return new Circle(r);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Круг радіусом {r}");
    }
}

class Triangle(int a, int b, int c) : IFigure
{
    public IFigure Clone()
    {
        return new Triangle(a, b, c);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Трикутник зі сторонами {a}, {b}, {c}");
    }
}