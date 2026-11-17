interface ITree
{
    void Show();
    void Light();
}

class Tree : ITree
{
    public void Show() => Console.WriteLine("Ялинка");
    bool hasGarland = false;

    public void Light()
    {
        if (hasGarland) Console.WriteLine("Не світиться");
    }
}

class Ornaments : ITree
{
    ITree tree;
    private string ornament;

    public Ornaments(ITree tree, string ornament)
    {
        this.tree = tree;
        this.ornament = ornament;
    }

    public void Show()
    {
        tree.Show();
        Console.WriteLine("  + прикраси: " + ornament);
    }

    public void Light() => tree.Light();
}

class Garland : ITree
{
    ITree tree;

    private static string[] colors =
    [
        "жовтим", "синім", "рожевим", "білим", "червоним"
    ];

    public Garland(ITree tree)
    {
        this.tree = tree;
    }


    public void Show()
    {
        tree.Show();
        Console.WriteLine("  + гірлянда");
    }
    
    private int index = new Random().Next(0, colors.Length);

    public void Light()
    {
        tree.Light();
        Console.WriteLine($"Гірлянда світиться {colors.GetValue(index)} кольором!");
    }
}