namespace Airline;

public class MainClass
{
    public static void Main(string[] args)
    {
        AirPlane embraer = new AirPlane("1123-875");
        Flight voo21 = new Flight("78", 345.6);

        voo21.airPlane = embraer;

        Console.WriteLine(voo21.airPlane.Prefix); 
        Console.WriteLine(voo21.Distance); 
        Console.WriteLine(voo21.FlightId);
        Console.WriteLine(voo21.CalculateCost().ToString());
    }
}