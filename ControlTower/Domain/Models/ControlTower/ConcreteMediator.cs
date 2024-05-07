using ControlTower.Domain.Interfaces;
using ControlTower.Domain.Models.Airlines;

namespace ControlTower.Domain.Models.ControlTower
{
    class ConcreteMediator : IMediator
    {
        private AzulBrazilianAirlines _azulBrazilianAirlines;
        private GolTransportesAereos _golTransportesAereos;
        private LatamAirlinesGroup _latamAirlinesGroup;
        private TapAirPortugal _tapAirPortugal;

        public ConcreteMediator(AzulBrazilianAirlines azulBrazilianAirlines, GolTransportesAereos golTransportesAereos, LatamAirlinesGroup latamAirlinesGroup, TapAirPortugal tapAirPortugal)
        {
            _azulBrazilianAirlines = azulBrazilianAirlines;
            _golTransportesAereos = golTransportesAereos;
            _latamAirlinesGroup = latamAirlinesGroup;
            _tapAirPortugal = tapAirPortugal;

            this._azulBrazilianAirlines.SetMediator(this);
            this._golTransportesAereos.SetMediator(this);
            this._latamAirlinesGroup.SetMediator(this);
            this._tapAirPortugal.SetMediator(this);
        }

        public void NotifyLand(object sender, string events)
        {
            if (events == "Azul")
            {
                Console.WriteLine($"Mediator reacts on [Event: {events}] and triggers following operations:");
                this._azulBrazilianAirlines.Land(sender);
            }
            if (events == "Gol")
            {
                Console.WriteLine($"Mediator reacts on [Event: {events}] and triggers following operations:");
                this._golTransportesAereos.Land(sender);
            }
            if (events == "Latam")
            {
                Console.WriteLine($"Mediator reacts on [Event: {events}] and triggers following operations:");
                this._golTransportesAereos.Land(sender);
            }
            if (events == "Tap")
            {
                Console.WriteLine($"Mediator reacts on [Event: {events}] and triggers following operations:");
                this._golTransportesAereos.Land(sender);
            }
        }

        public void NotifyTakeOff(object sender, string events)
        {
            if (events == "Azul")
            {
                Console.WriteLine($"Mediator reacts on [Event: {events}] and triggers following operations:");
                this._azulBrazilianAirlines.TakeOff(sender);
            }
            if (events == "Gol")
            {
                Console.WriteLine($"Mediator reacts on [Event: {events}] and triggers following operations:");
                this._golTransportesAereos.TakeOff(sender);
            }
            if (events == "Latam")
            {
                Console.WriteLine($"Mediator reacts on [Event: {events}] and triggers following operations:");
                this._golTransportesAereos.TakeOff(sender);
            }
            if (events == "Tap")
            {
                Console.WriteLine($"Mediator reacts on [Event: {events}] and triggers following operations:");
                this._golTransportesAereos.TakeOff(sender);
            }
        }
    }
}
