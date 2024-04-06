using System.Text.RegularExpressions;
using CarFactory.Models.Brand;
using CarFactory.Models.Colors;
using CarFactory.Models.Engines;
using CarFactory.Models.Shapes;
using CarFactory.Models.SteeringPosition;
using CarFactory.Models.Transmission;

namespace CarFactory;

public class CreateCars
{
    public static string CarName()
    {
        string fighterName = CheckCarName(); 
        return fighterName;
    }

    public static IBrand CreateBrand()
    {
        Console.WriteLine("Выберите марку автомобиля(пункты от 1 до 3)");
        Console.WriteLine("1. Audi");
        Console.WriteLine("2. Honda");
        Console.WriteLine("3. Tesla");
        int choice = GetValidChoice(3);

        switch (choice)
        {
            case 1:
                return new Audi();
            case 2:
                return new Honda();
            case 3: 
                return new Tesla();
            default:
                return new Audi();
        }
    }

    public static IColor CreateColor()
    {
        Console.WriteLine("Выберите цвет автомобиля(пункты от 1 до 3)");
        Console.WriteLine("1. Белый");
        Console.WriteLine("2. Зеленый");
        Console.WriteLine("3. Красный");
        int choice = GetValidChoice(3);

        switch (choice)
        {
            case 1:
                return new White();
            case 2:
                return new Green();
            case 3:
                return new Red();
            default:
                return new White();
        }
    }

    public static IShape CreateShape()
    {
        Console.WriteLine("Выберите класс машины(пункты от 1 до 3)");
        Console.WriteLine("1. Седан");
        Console.WriteLine("2. Лифтбек");
        Console.WriteLine("3. Кроссовер");
        int choice = GetValidChoice(3);

        switch (choice)
        {
            case 1:
                return new SedanShape();
            case 2:
                return new LiftbackShape();
            case 3:
                return new SUVShape();
            default:
                return new SedanShape();
        }
    }

    public static IEngine CreateEngine()
    {
        Console.WriteLine("Выберите двигатель машины(пункты от 1 до 3)");
        Console.WriteLine("1. Бензиновый");
        Console.WriteLine("2. Дизельный");
        Console.WriteLine("3. Электрический");
        int choice = GetValidChoice(3);

        switch (choice)
        {
            case 1:
                return new GasolineEngine();
            case 2:
                return new DiselEngine();
            case 3:
                return new ElectricEngine();
            default:
                return new GasolineEngine();
        }
    }

    public static ISteeringPosition CreateSteeringPosition()
    {
        Console.WriteLine("Выберите розицию руля(пункты от 1 до 2)");
        Console.WriteLine("1. Леворульная");
        Console.WriteLine("2. Праворульная");
        int choice = GetValidChoice(2);

        switch (choice)
        {
            case 1:
                return new LeftSteeringPosition();
            case 2:
                return new RightSteeringPosition();
            default:
                return new RightSteeringPosition();
        }
    }

    public static ITransmission CreateTransmission()
    {
        Console.WriteLine("Выберите коробку передач(пункты от 1 до 2)");
        Console.WriteLine("1. Механическая");
        Console.WriteLine("2. Автоматическая");
        Console.WriteLine("3. DSG");
        int choice = GetValidChoice(3);

        switch (choice)
        {
            case 1:
                return new ManualTransmission();
            case 2:
                return new AutomaticTransmission();
            case 3:
                return new DSGTransmission();
            default:
                return new ManualTransmission();
        }
    }
    private static int GetValidChoice(int num)
    {
        int number;
        while (true)
        {
            Console.Write($"Введите число от 1 до {num}: ");
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
            if (number < 1 || number > num)
            {
                Console.WriteLine($"Число должно быть от 1 до {num}. Попробуйте снова.");
                continue;
            }
            return number;
        }
    }
    private static string CheckCarName()
    {
        while (true)
        {
            Console.Write("Введите имя владельца машины на английском: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Имя владельца машины не может быть пустым. Попробуйте снова.");
                continue;
            }
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Имя владельца машины должно содержать только английские буквы. Попробуйте снова.");
                continue;
            }
            return name;
        }
    }
}