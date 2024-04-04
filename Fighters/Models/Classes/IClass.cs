namespace Fighters.Models.Classes;

public interface IClass
{
    string Name { get; }
    int Damage { get; }
    int Health { get; }
    int Initiative { get; }
}    