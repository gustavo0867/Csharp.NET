namespace Airline;

public class PassengerAirPlane : AirPlane
{

    private int PassengerCapacity { get; set; }
    private int PassengerQuantity = 0;   
    

    public PassengerAirPlane(string Prefix, int PassengerCapacity) : base(Prefix)
    {
        this.PassengerCapacity = PassengerCapacity;
    }


    public void Load()
    {
        
        if(PassengerQuantity==PassengerCapacity)
        {
            throw new ArgumentException("Todos lugares estão ocupados");
        }

        PassengerQuantity += 1;
    }

}