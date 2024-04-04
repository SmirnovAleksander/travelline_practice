namespace Fighters.Models.Weapons;

public class Sword : IWeapon
{
    public string Name { get; } = "Меч";
    public int Damage { get; } = 6;
}