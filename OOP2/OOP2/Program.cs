namespace OOPNomer3;
class Program
{
    static void Main(string[] args)
    {
        Converter Lombard = new Converter(37.01M, 38.19M);
        Console.WriteLine("Enter your ballance");
        double input = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your currency (UAH\\USD\\EUR)");
        string curr = Console.ReadLine();
        if (curr == "UAH")
        {
            Console.WriteLine("You have " + Lombard.HrivniaToDollar(input) + " dollars, or..");
            Console.WriteLine("You have " +  Lombard.HrivniaToEuro(input)+ " euros");
            return;
        } else if(curr == "USD")
        {
            Console.WriteLine("You have " + Lombard.DollarToHrivnia(input) + " hryvnyas");
        } else {
            Console.WriteLine("You have " + Lombard.EuroToHrivnia(input) + " hryvnyas");
        }
    }
}
