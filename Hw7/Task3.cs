abstract class Mediator
{
    public abstract void Send(string message, Colleague sender);
}

class ConcreteMediator : Mediator
{
    private ConcreteColleague1 colleague1;
    private ConcreteColleague2 colleague2;
    private ConcreteCollegue3 collegue3;

    public ConcreteColleague1 Colleague1
    {
        set { colleague1 = value; }
    }

    public ConcreteColleague2 Colleague2
    {
        set { colleague2 = value; }
    }

    public ConcreteCollegue3 Collegue3
    {
        set { collegue3 = value; }
    }

    public override void Send(string message, Colleague sender)
    {
        if (sender != colleague1)
        {
            colleague1.Notify(message);
        }
        if (sender != colleague2)
        {
            colleague2.Notify(message);
        }
        if (sender != collegue3)
        {
            collegue3.Notify(message);
        }
    }
}

abstract class Colleague(Mediator mediator)
{
    protected Mediator mediator = mediator;
}

class ConcreteColleague1(Mediator mediator) : Colleague(mediator)
{
    public void Send(string message)
    {
        mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("Colleague1 gets message: " + message);
    }
}

class ConcreteColleague2(Mediator mediator) : Colleague(mediator)
{
    public void Send(string message)
    {
        mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("Colleague2 gets message: " + message);
    }
}

class ConcreteCollegue3(Mediator mediator) : Colleague(mediator)
{
    public void Send(string message)
    {
        mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("Collegue3 gets message: " + message);
    }
}