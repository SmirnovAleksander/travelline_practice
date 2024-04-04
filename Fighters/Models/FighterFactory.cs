using System.Diagnostics.CodeAnalysis;
using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models;

public class FighterFactory
{
    public static Fighter CreateFighter()
    {
        Console.Write("Введите имя бойца: ");
        string name = Console.ReadLine();

        IRace race = CreateRace();
        IWeapon weapon = CreateWeapon();
        IArmor armor = CreateArmor();
        IClass playerclass = CreateClass();
        Fighter newFighter = new Fighter(name, weapon, race, armor, playerclass);
        return newFighter;
    }

    private static IClass CreateClass()
    {
        Console.WriteLine("Меню выбора классов. Выберите класс бойца");
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
        Console.WriteLine("Меню выбора классов. Выберите броню для бойца");
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
        Console.WriteLine("Меню выбора классов. Выберите оружие для бойца");
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
        Console.WriteLine("Меню выбора классов. Выберите рассу бойца");
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
        int choice;
        while (int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Ошибка! Пожалуйста, выберите один из предложенных вариантов.");
        }
        return choice;
    }
}