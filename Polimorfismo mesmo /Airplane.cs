namespace Airline;

public abstract class Airplane : IAirplane
{
    public string Prefix { get; set; }

    public Airplane(string Prefix)
    {
        this.Prefix = Prefix;
    }

    public abstract void Load(int passageiro){}

    public abstract void Load(double weight){}
    public abstract double CalculateCost( ) {
        return 0;
    }

    public double CalculateStandardCost()
    {
        return 1352.45;
    }
}