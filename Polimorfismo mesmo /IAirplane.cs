namespace Airline;

public interface IAirplane
{
    string Prefix { get; set; }
    void Load(int passageiro);
    void Load(double weight);
    double CalculateCost();
}