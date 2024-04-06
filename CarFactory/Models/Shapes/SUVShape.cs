namespace CarFactory.Models.Shapes;

public class SUVShape : IShape
{
    public string Name { get; } = "Кроссовер";
    public double AirResistanceCoefficient { get; } = 0.35d;
    public double SCar { get; } = 3.0d;
}