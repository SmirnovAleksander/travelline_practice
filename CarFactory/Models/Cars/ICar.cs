using CarFactory.Models.Brand;
using CarFactory.Models.Colors;
using CarFactory.Models.Engines;
using CarFactory.Models.Shapes;
using CarFactory.Models.SteeringPosition;
using CarFactory.Models.Transmission;

namespace CarFactory.Models.Cars;

public interface ICar : IModel
{
    int MaxSpeed { get; }
    IColor Color { get;  }
    IBrand Brand { get;  }
    IShape Shape { get;  }
    ISteeringPosition SteeringPosition { get;  }
    ITransmission Transmission { get;  }
    IEngine Engine { get; }
}