namespace Fighters.Models.Weapons
{
    public class NoWeapon : IWeapon
    {
        public string Name { get; } = "Без оружия";
        public int Damage { get; } = 1;
    }
}