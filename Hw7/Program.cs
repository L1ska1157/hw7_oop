void task1()
{
    Console.WriteLine("\n=== TASK 1 ===");
    
    ICarFactory carFactory = new ToyotaFactory();
    Car myCar = carFactory.CreateCar();
    myCar.Info();
    Engine myEngine = carFactory.CreateEngine();
    myEngine.GetPower();

    carFactory = new FordFactory();
    myCar = carFactory.CreateCar();
    myCar.Info();
    myEngine = carFactory.CreateEngine();
    myEngine.GetPower();

    carFactory = new MersedesFactory();
    myCar = carFactory.CreateCar();
    myCar.Info();
    myEngine = carFactory.CreateEngine();
    myEngine.GetPower();
}

void task2()
{
    Console.WriteLine("\n=== TASK 2 ===");
    
    Waiter waiter = new Waiter();
    PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
    PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
    PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();

    waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
    waiter.ConstructPizza();
    Pizza pizza = waiter.GetPizza();
    pizza.Info();
    
    waiter.SetPizzaBuilder(spicyPizzaBuilder);
    waiter.ConstructPizza();
    pizza = waiter.GetPizza();
    pizza.Info();

    waiter.SetPizzaBuilder(margaritaPizzaBuilder);
    waiter.ConstructPizza();
    pizza = waiter.GetPizza();
    pizza.Info();
}

void task3()
{
    Console.WriteLine("\n=== TASK 3 ===");
    
    ConcreteMediator m = new ConcreteMediator();
    ConcreteColleague1 c1 = new ConcreteColleague1(m);
    ConcreteColleague2 c2 = new ConcreteColleague2(m);
    ConcreteCollegue3 c3 = new ConcreteCollegue3(m);

    m.Colleague1 = c1;
    m.Colleague2 = c2;
    m.Collegue3 = c3;

    m.Send("How are you?", c1);
    m.Send("Fine, thanks", c2);
    m.Send("Hello!", c3);
    
    c1.Send("Message from c1");
}

void task4()
{
    Console.WriteLine("\n=== TASK 4 ===");
    ITree tree = new Tree();
    tree.Show();
    tree.Light();

    tree = new Garland(new Ornaments(new Garland(new Ornaments(tree, "кулі")), "дощик"));
    tree.Show();
    tree.Light();
}

void task5()
{
    Console.WriteLine("\n=== TASK 5 ===");
    IFigure figure = new Rectangle(10, 20);
    IFigure clonedFigure = figure.Clone();
    figure.GetInfo();
    clonedFigure.GetInfo();

    figure = new Circle(15);
    clonedFigure = figure.Clone();
    figure.GetInfo();
    clonedFigure.GetInfo();

    figure = new Triangle(3, 4, 5);
    clonedFigure = figure.Clone();
    figure.GetInfo();
    clonedFigure.GetInfo();
}

void task6()
{
    Console.WriteLine("\n=== TASK 6.1 ===");
    var root = new Folder("Root");
    var docs = new Folder("Документи");
    docs.Add(new FileItem("lab1.docx", 120));
    docs.Add(new FileItem("report.pdf", 450));

    root.Add(docs);
    root.Add(new FileItem("readme.txt", 5));

    root.Print(0);
    Console.WriteLine($"Загальний розмір: {root.GetSize()} КБ");
    
    Console.WriteLine("\n=== TASK 6.2 ===");
    
    ITemperatureSensor sensor = new CelsiusSensor(21.5);
    Console.WriteLine($"Датчик 1: {sensor.GetCelsius()} °C");

    sensor = new FahrenheitAdapter(new FahrenheitSensor(98.6));
    Console.WriteLine($"Датчик 2: {sensor.GetCelsius()} °C");
}

task1();
task2();
task3();
task4();
task5();
task6();