namespace Fighters.Models.Classes;

public class Mage : IClass
{
    public string Name { get; } = "Колдун";
    public int Damage { get; } = 6;
    public int Health { get; } = 3;
    public int Initiative { get; } = 2;
}