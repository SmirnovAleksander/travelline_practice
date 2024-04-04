namespace Fighters.Models.Races
{
    public class Orc : IRace
    {
        public string Name { get; } = "Orc";
        public int Damage { get; } = 15;
        public int Health { get; } = 150;
        public int Armor { get; } = 8;
        public int Initiative { get; } = 1;
    }
}