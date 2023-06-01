Console.WriteLine("Plan Your Heist");
Console.WriteLine("---------------");
Console.WriteLine("Choose your team");
string name = Console.ReadLine();
Console.WriteLine("Now, choose your skill level");
int skillLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now, your courage factor is a decimal number between 0.0 and 2.0. Choose Wisely");
decimal courageFactor = Decimal.Parse(Console.ReadLine());
Console.WriteLine($"Hello {name}");
Console.WriteLine($"Your skill level is {skillLevel}");
Console.WriteLine($"Your courage factor is {courageFactor}");

public class Member{
    public string name;
    public int skillLevel;

    public decimal courageFactor;
}


