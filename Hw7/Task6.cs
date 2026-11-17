// Patter composite, file system
abstract class FSItem(string name)
{
    protected string name = name;

    public abstract void Print(int indent);
    public abstract int GetSize();
}

class FileItem(string name, int size) : FSItem(name)
{
    public override void Print(int indent) =>
        Console.WriteLine(new string(' ', indent) + $"{name} ({size} КБ)");

    public override int GetSize() => size;
}

class Folder(string name) : FSItem(name)
{
    private List<FSItem> items = new();

    public void Add(FSItem item) => items.Add(item);

    public override void Print(int indent)
    {
        Console.WriteLine(new string(' ', indent) + $"[{name}]");
        foreach (var item in items)
            item.Print(indent + 2);
    }

    public override int GetSize()
    {
        int total = 0;
        foreach (var item in items)
            total += item.GetSize();
        return total;
    }
}


// Pattern adapter, temperature
interface ITemperatureSensor
{
    double GetCelsius();
}

class CelsiusSensor(double t) : ITemperatureSensor
{
    public double GetCelsius() => t;
}

class FahrenheitSensor(double t)
{
    public double GetFahrenheit() => t;
}

class FahrenheitAdapter(FahrenheitSensor sensor) : ITemperatureSensor
{
    public double GetCelsius() => (sensor.GetFahrenheit() - 32) * 5 / 9;
}
