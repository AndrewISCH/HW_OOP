namespace ConsoleApp1;

public class Manager : Worker
{
    private readonly Random random = new();
    
    private void CallNTimes(int times)
    {
        for (int j = 0; j < times; j++)
        {
            Call();
        }
    }
    
    public Manager(string name) : base(name)
    {
        Position = "Manager";
    }
    
    public override void FillWorkDay()
    {
        CallNTimes(random.Next(1,10));
        Relax();
        CallNTimes(random.Next(1,5));
    }
}