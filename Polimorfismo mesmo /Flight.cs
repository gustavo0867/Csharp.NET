namespace Airline;

public class Flight
{
    public string FlightId { get; set; }
    public double Distance;

    private string _FlightType;
    private IAirplane? _Airplane;
    public IAirplane? Airplane { 
        get { return _Airplane; } 
        set
        {
            if (value.GetType() == typeof(PassengerAirplane))
            {
                _FlightType = "Commercial";
            }
            else
            {
                _FlightType = "Cargo";
            }
            _Airplane = value;
        } 
    }

    public Flight(string FlightId, double Distance)
    {
        this.FlightId = FlightId;
        this.Distance = Distance;
    }


    public void Load(int passageiro)
    {
        if( _Airplane == null) throw new InvalidDataException("Airplane não está definido!");
        _Airplane.Load(passageiro);
    }

    public void Load(double weight)
    {   
        if( _Airplane == null) throw new InvalidDataException("Airplane não está definido!");
        _Airplane.Load(weight);
    }

     public double CalculateCost()
    {
        if( _Airplane == null) throw new InvalidDataException("Airplane não está definido!");
        return 20 * Distance + _Airplane!.CalculateCost();
    }
}