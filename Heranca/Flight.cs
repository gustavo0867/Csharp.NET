namespace Airline;

public class Flight
{
    public string FlightId {get; set;}
    public double Distance {get; set;}

    public AirPlane teste { get; set; }


    public Flight(string FlightId, double Distance)
    {
        this.FlightId = FlightId;
        this.Distance = Distance;
    }

    public double CalculateCost()
    {
        return teste.CalculateCost();
    }

}

