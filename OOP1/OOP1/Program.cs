namespace ConsoleApp1;

class Program
{
    public static void Main()
    {
        Worker dev = new Developer("Andrew");
        dev.FillWorkDay();
        Worker manager = new Manager("Misha");
        manager.FillWorkDay();
        Team team = new("Project Team");
        team.AddNewMember(dev);
        team.AddNewMember(manager);
        team.ShowDetailedInfo();
    }
}