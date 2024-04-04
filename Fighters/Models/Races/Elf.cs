namespace Fighters.Models.Races
{
    public class Elf : IRace
    {
        public string Name { get; } = "Elf";
        public int Damage { get; } = 8;
        public int Health { get; } = 80;
        public int Armor { get; } = 5;
        public int Initiative { get; } = 3;
    }
}