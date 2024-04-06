namespace Fighters.Models.Weapons;

public class Bow : IWeapon
{
    public string Name { get; } = "Лук";
    public int Damage { get; } = 8;
}