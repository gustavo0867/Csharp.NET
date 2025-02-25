namespace Airline;

public class AirPlane
{
    public string Prefix {get; set;}



    public AirPlane(string Prefix)
    {
        this.Prefix = Prefix;
    }


    public double CalculateCost()
    {
        return 1200;
    }
}