using System.Text.RegularExpressions;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Weapons;

namespace Fighters
{
    public class Program
    {
        public static void Main()
        {

            var firstFighter = new Fighter(FighterName(), CreateWeapon(), CreateRace(), CreateArmor(), CreateClass());
            Console.WriteLine($"Первый боец: {firstFighter.Name}");
            firstFighter.FighterInfo();
            
            var secondFighter = new Fighter(FighterName(), CreateWeapon(), CreateRace(), CreateArmor(), CreateClass() );
            Console.WriteLine($"Второй боец: {firstFighter.Name}");
            secondFighter.FighterInfo();
            
            var master = new GameMaster();
            var winner = master.PlayAndGetWinner(firstFighter, secondFighter);

            Console.WriteLine($"Выигрывает  {winner.Name}");
        }
        
        public static string FighterName()
        {
            string fighterName = CheckFighterName(); 
            return fighterName;
        }
        
        private static IClass CreateClass()
        {
            Console.WriteLine("Меню выбора классов. Выберите класс бойца(пункты от 1 до 3)");
            Console.WriteLine("1. Маг");
            Console.WriteLine("2. Рыцарь");
            Console.WriteLine("3. Наемник");
            int choice = GetValidChoice();

            switch (choice)
            {
                case 1:
                    return new Mage();
                case 2:
                    return new Knight();
                case 3:
                    return new Mercenary();
                default:
                    return new Mage();
            }
        }
        
        private static IArmor CreateArmor()
        {
            Console.WriteLine("Меню выбора классов. Выберите броню для бойца(пункты от 1 до 3)");
            Console.WriteLine("1. Без брони");
            Console.WriteLine("2. Кольчуга");
            Console.WriteLine("3. Латные доспехи");
            int choice = GetValidChoice();

            switch (choice)
            {
                case 1:
                    return new NoArmor();
                case 2:
                    return new ChainMailArmor();
                case 3:
                    return new PlateArmor();
                default:
                    return new NoArmor();
            }
        }
        
        private static IWeapon CreateWeapon()
        {
            Console.WriteLine("Меню выбора классов. Выберите оружие для бойца(пункты от 1 до 3)");
            Console.WriteLine("1. Без оружия");
            Console.WriteLine("2. Меч");
            Console.WriteLine("3. Лук");
            int choice = GetValidChoice();

            switch (choice)
            {
                case 1:
                    return new NoWeapon();
                case 2:
                    return new Sword();
                case 3:
                    return new Bow();
                default:
                    return new NoWeapon();
            }
        }
        
        private static IRace CreateRace()
        {
            Console.WriteLine("Меню выбора классов. Выберите рассу бойца(пункты от 1 до 3)");
            Console.WriteLine("1. Человек4");
            Console.WriteLine("2. Эльф");
            Console.WriteLine("3. Орк");
            int choice = GetValidChoice();

            switch (choice)
            {
                case 1:
                    return new Human();
                case 2:
                    return new Elf();
                case 3:
                    return new Orc();
                default:
                    return new Human();
            }
        }
        
        
        private static int GetValidChoice()
        {
            int number;
            while (true)
            {
                Console.Write("Введите число от 1 до 3: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Вы ввели пустую строку. Попробуйте снова.");
                    continue;
                }
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Вы ввели не число. Попробуйте снова.");
                    continue;
                }
                if (number < 1 || number > 3)
                {
                    Console.WriteLine("Число должно быть от 1 до 3. Попробуйте снова.");
                    continue;
                }
                return number;
            }
        }
        private static string CheckFighterName()
        {
            while (true)
            {
                Console.Write("Введите имя бойца на английском: ");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Имя бойца не может быть пустым. Попробуйте снова.");
                    continue;
                }
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Имя бойца должно содержать только английские буквы. Попробуйте снова.");
                    continue;
                }
                return name;
            }
        }
    }

    public class GameMaster
    {
        public IFighter PlayAndGetWinner( IFighter firstFighter, IFighter secondFighter )
        {
            int round = 1;
            while ( true )
            {
                Console.WriteLine( $"Раунд {round++}." );

                // First fights second
                if ( FightAndCheckIfOpponentDead( firstFighter, secondFighter ) )
                {
                    return firstFighter;
                }

                // Second fights first
                if ( FightAndCheckIfOpponentDead( secondFighter, firstFighter ) )
                {
                    return secondFighter;
                }

                Console.WriteLine();
            }
        }

        private bool FightAndCheckIfOpponentDead( IFighter roundOwner, IFighter opponent )
        {
            int damage = roundOwner.CalculateDamage();
            opponent.TakeDamage(damage);

            Console.WriteLine(
                $"Боец {opponent.Name} получает {damage} урона. " +
                $"Количество жизней: {opponent.CurrentHealth}" );

            return opponent.CurrentHealth < 1;
        }
    }
}