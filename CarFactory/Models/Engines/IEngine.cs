namespace CarFactory.Models.Engines;

public interface IEngine : IModel
{
    int EngineRPM { get;  }
}