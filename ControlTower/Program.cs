using ControlTower.Domain.Models.Airlines;
using ControlTower.Domain.Models.ControlTower;

Console.WriteLine("========== AIRPORT FULL OF CODE ==========");
Console.WriteLine("This airport carries out just 5 events per day");
Console.WriteLine("## Click [Enter] to initialize ##");
Console.ReadLine();

AzulBrazilianAirlines azul = new AzulBrazilianAirlines();
GolTransportesAereos gol = new GolTransportesAereos();
LatamAirlinesGroup latam = new LatamAirlinesGroup();
TapAirPortugal tap = new TapAirPortugal();

new ConcreteMediator(azul, gol, latam, tap);

string[] events = { "land", "takeoff" };
string[] airplanes = { "azul", "gol", "latam", "tap" };

var c = 1;
while (c <= 5)
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("     Waiting for airplane     ");
    Console.WriteLine("------------------------------");

    Thread.Sleep(5000);
    Console.WriteLine();

    Console.WriteLine($"[AIRPLANE Nº {c}]");

    Random random = new Random();
    int indexEvents = random.Next(events.Length);
    int indexAirplanes = random.Next(airplanes.Length);

    if (events[indexEvents] == "land")
    {
        if (airplanes[indexAirplanes] == "azul")
        {
            azul.DoLanding();
        }
        if (airplanes[indexAirplanes] == "gol")
        {
            gol.DoLanding();
        }
        if (airplanes[indexAirplanes] == "latam")
        {
            latam.DoLanding();
        }
        if (airplanes[indexAirplanes] == "tap")
        {
            tap.DoLanding();
        }
    }

    if (events[indexEvents] == "takeoff")
    {
        if (airplanes[indexAirplanes] == "azul")
        {
            azul.DoTakeOff();
        }
        if (airplanes[indexAirplanes] == "gol")
        {
            gol.DoTakeOff();
        }
        if (airplanes[indexAirplanes] == "latam")
        {
            latam.DoTakeOff();
        }
        if (airplanes[indexAirplanes] == "tap")
        {
            tap.DoTakeOff();
        }
    }
    
    c++;
}

Console.WriteLine();
Console.WriteLine("xxx AIRPORT CLOSING xxx");
Console.WriteLine("## Click [Enter] to finalize ##");
Console.ReadLine();