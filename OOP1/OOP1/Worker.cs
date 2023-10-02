namespace ConsoleApp1;

public abstract class Worker
{
    public string Name { get; }
    public string? Position { get; protected set; }
    public string? Workday;
    
    protected Worker(string name)
    {
        Name = name;
    }

    protected void Call()
    {
        Workday += 'C';
    }

    protected void WriteCode()
    {
        Workday += 'W';
    }

    protected void Relax()
    {
        Workday += 'R';
    }

    public abstract void FillWorkDay();
}

