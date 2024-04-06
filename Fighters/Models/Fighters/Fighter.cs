using System.Runtime.InteropServices;
using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters
{
    public class Fighter : IFighter
    {
        public string Name { get; }
        public int MaxHealth => Race.Health + Class.Health;
        public int FullArmor => Race.Armor + Armor.Armor;
        public int Initiative => Race.Initiative + Class.Initiative;
        public int CurrentHealth { get; private set; }
        
        public IRace Race { get; }
        public IWeapon Weapon { get; } 
        public IArmor Armor { get;}
        public IClass Class { get; }

        public Fighter( string name, IWeapon weapon, IRace race, IArmor armor, IClass playerClass)
        {
            Name = name;
            Weapon = weapon;
            Race = race;
            Armor = armor;
            Class = playerClass;
            CurrentHealth = MaxHealth;
        }

        public int CalculateDamage()
        {
            Random random = new Random();
            int fullDamage = Race.Damage + Class.Damage + Weapon.Damage;
            double randDamage = random.Next(80, 111) / 100d;
            double resulDamage = fullDamage * randDamage;
            if (random.NextDouble() < 0.3)
            {
                return (int)(resulDamage * 3);
            }
            else
            {
                return (int)(resulDamage);
            }
        }
        
        public void TakeDamage(int damage)
        {
            CurrentHealth -= Math.Max(damage - FullArmor, 0);
            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }
        public void FighterInfo()
        {
            Console.WriteLine($"________________\nName: {Name}\nClassName: {Class.Name}\nRace: {Race.Name}\nArmor: {Armor.Name}\nWeapon: {Weapon.Name}\nInitiative: {Initiative}\nHealth: {MaxHealth}\n________________");
        }

    }
}