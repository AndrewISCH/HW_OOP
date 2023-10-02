namespace ConsoleApp1;

public abstract class Worker
{
    public string Name { get; }
    public string? Position { get; protected set; }
    
    protected Worker(string name)
    {
        Name = name;
    }

    protected void Call()
    {
        Console.WriteLine("call...");
    }

    protected void WriteCode()
    {
        Console.WriteLine("write code....");
    }

    protected void Relax()
    {
        Console.WriteLine("relaxing...");   
    }

    public abstract void FillWorkDay();
}

