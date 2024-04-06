namespace CarFactory.Models.Shapes;

public class LiftbackShape : IShape
{
    public string Name { get; } = "Лифтбек";
    public double AirResistanceCoefficient { get; } = 0.27d;
    public double SCar { get; } = 2.0d;
}