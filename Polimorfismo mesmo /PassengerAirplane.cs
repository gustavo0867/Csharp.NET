namespace Airline;

public class PassengerAirplane : Airplane
{
    private int PassengerCapacity { get; set; }
    private int PassengerQuantity = 0;

    
    public PassengerAirplane(string Prefix, int PassengerCapacity) : base(Prefix)
    {
        this.PassengerCapacity = PassengerCapacity;
    }

    public override void Load(int passageiro)
    {   

        int quantidadePassada = passageiro+PassengerQuantity;
        Console.WriteLine($"Quantidade de passageiros passados = {quantidadePassada}");
        Console.WriteLine($"Quantidade máxima = {PassengerCapacity}");
        if (quantidadePassada >= PassengerCapacity) throw new ArgumentException("No seats left");

        PassengerQuantity += passageiro;
    }

    public override double CalculateCost()
    {
        return CalculateStandardCost() + 90.0 *PassengerQuantity;
    }

}