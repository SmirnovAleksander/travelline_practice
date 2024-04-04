namespace Fighters.Models.Classes;

public class Knight : IClass
{
    public string Name { get; } = "Рыцарь";
    public int Damage { get; } = 4;
    public int Health { get; } = 8;
    public int Initiative { get; } = 1;
}