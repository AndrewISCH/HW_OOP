namespace ConsoleApp1;

public class Team
{
    private readonly string name;
    
    private readonly List<Worker> workers = new();

    public Team(string name)
    {
        this.name = name;
    }

    public void AddNewMember(Worker worker)
    {
        workers.Add(worker);
    }

    public void ShowInfo()
    {
        Console.WriteLine("Team: " + name);
        foreach (var worker in workers)
        {
            Console.WriteLine(worker.Name);
        }
    }

    public void ShowDetailedInfo()
    {
        Console.WriteLine("Team: " + name);
        foreach (Worker worker in workers)
        {
            Console.WriteLine(worker.Name + " - " + worker.Position);
        }
    }
}