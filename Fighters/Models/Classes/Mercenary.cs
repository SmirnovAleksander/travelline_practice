namespace Fighters.Models.Classes;

public class Mercenary : IClass
{
    public string Name { get; } = "Наемник";
    public int Damage { get; } = 4;
    public int Health { get; } = 4; 
    public int Initiative { get; } = 3;
}