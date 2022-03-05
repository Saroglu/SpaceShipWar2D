using SpaceShipWar2D.Abstracts.DataContainers;
using SpaceShipWar2D.Abstracts.Inputs;

namespace SpaceShipWar2D.Abstracts.Controllers
{
    public interface IPlayerController : IEntityController
    {
        IInputReader InputReader { get; }
        IPlayerStats Stats { get; }
    }
}

