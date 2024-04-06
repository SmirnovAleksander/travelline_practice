using CarFactory.Models.Brand;
using CarFactory.Models.Colors;
using CarFactory.Models.Engines;
using CarFactory.Models.Shapes;
using CarFactory.Models.SteeringPosition;
using CarFactory.Models.Transmission;

namespace CarFactory.Models.Cars;

public class Car : ICar
{
    public string Name { get; }
    public int MaxSpeed { get; }
    
    public IColor Color { get; }
    public IBrand Brand { get; }
    public IShape Shape { get; }
    public ISteeringPosition SteeringPosition { get; }
    public ITransmission Transmission { get; }
    public IEngine Engine { get; }

    public Car(string name, IBrand brand, IColor color, IShape shape, IEngine engine, ISteeringPosition steeringPosition, ITransmission transmission)
    {
        Name = name;
        Brand = brand;
        Color = color;
        Shape = shape;
        Engine = engine;
        SteeringPosition = steeringPosition;
        Transmission = transmission;
        
        MaxSpeed = CalculateMaxSpeed();
    }
    
    public int CalculateMaxSpeed()
    {
        double AerodynamicDragForceResul = 0.5 * Shape.AirResistanceCoefficient * 1.225 * 27.78 * 27.78 * Shape.SCar;
        double MaxSpeedRes = (Engine.EngineRPM * Transmission.Efficiency) /
                             (Shape.AirResistanceCoefficient * Shape.SCar * AerodynamicDragForceResul);
        return (int)MaxSpeedRes * 10;
    }

    public void CarInfo()
    {
          Console.WriteLine($"\nCarName: {Name}\n" +
                            $"Brand: {Brand.Name}\n" +
                            $"Color: {Color.Name}\n" +
                            $"ShapeBody: {Shape.Name}\n" +
                            $"Engine: {Engine.Name}\n" +
                            $"SteeringPosition: {SteeringPosition.Name}\n" +
                            $"Transmission: {Transmission.Name}\n");
    }
}