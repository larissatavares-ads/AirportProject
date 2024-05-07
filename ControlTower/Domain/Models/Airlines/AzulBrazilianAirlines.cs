using ControlTower.Domain.Interfaces;

namespace ControlTower.Domain.Models.Airlines
{
    class AzulBrazilianAirlines : BaseAirlineComponent
    {
        public void DoLanding()
        {
            Console.WriteLine($"*** Airplane of {this.GetType().Name} wants to LAND.");
            Console.WriteLine();

            this._mediator.NotifyLand(this, "Azul");
        }

        public void DoTakeOff()
        {
            Console.WriteLine($"*** Airplane of {this.GetType().Name} wants to TAKE OFF.");
            Console.WriteLine();

            this._mediator.NotifyTakeOff(this, "Azul");
        }
    }
}
