namespace Airline;

public class MainClass
{
    public static void Main(string[] args)
    {
        PassengerAirPlane embraer = new PassengerAirPlane("1123-875", 2);
        Flight voo21 = new Flight("78", 345.6);
        voo21.teste = embraer;

        embraer.Load();
        embraer.Load();
        embraer.Load();


        Console.WriteLine(voo21.teste.Prefix); 
        Console.WriteLine(voo21.Distance); 
        Console.WriteLine(voo21.FlightId);
        Console.WriteLine(voo21.CalculateCost().ToString());
    }
}