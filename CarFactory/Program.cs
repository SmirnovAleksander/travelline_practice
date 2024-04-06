using CarFactory.Models.Cars;

namespace CarFactory;

public class Program
{
    public static void Main()
    {
        var newCar = new Car(CreateCars.CarName(), 
            CreateCars.CreateBrand(), 
            CreateCars.CreateColor(), 
            CreateCars.CreateShape(), 
            CreateCars.CreateEngine(), 
            CreateCars.CreateSteeringPosition(), 
            CreateCars.CreateTransmission());
        Console.WriteLine($"Ваша машина: {newCar.Name}");
        newCar.CarInfo();
        double resultSpeed = newCar.CalculateMaxSpeed();
        Console.WriteLine($"Максимальная скорость автомобиля {newCar.Name}: {resultSpeed}");
    }
    
}