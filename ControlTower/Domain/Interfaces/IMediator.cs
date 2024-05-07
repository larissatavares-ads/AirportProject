namespace ControlTower.Domain.Interfaces
{
    public interface IMediator
    {
        void NotifyLand(object sender, string events);
        void NotifyTakeOff(object sender, string events);
    }
}
