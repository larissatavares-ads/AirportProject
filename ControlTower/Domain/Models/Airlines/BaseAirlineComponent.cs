using ControlTower.Domain.Interfaces;

namespace ControlTower.Domain.Models.Airlines
{
    class BaseAirlineComponent
    {
        protected IMediator _mediator;

        public BaseAirlineComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public void Land(object sender)
        {
            Console.WriteLine();
            Console.WriteLine($"~~~ Airplane is LANDING ~~~");

            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50);
                Console.Write("\r{0}%   ", i);
            }

            Console.WriteLine();
            Console.WriteLine("~~~  LANDING COMPLETED  ~~~");
            Console.WriteLine();
        }

        public void TakeOff(object sender)
        {
            Console.WriteLine();
            Console.WriteLine($"~~~ Airplane is TAKING OFF ~~~");

            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50);
                Console.Write("\r{0}%   ", i);
            }

            Console.WriteLine();
            Console.WriteLine("~~~   TAKE OFF COMPLETED   ~~~");
            Console.WriteLine();
        }
    }
}
