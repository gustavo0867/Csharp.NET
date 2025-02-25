using teste;

namespace filmes
{

public class MoviePrincipal
{
    public static void Main(string[] args)
    {
        

        Console.WriteLine("Digite seu filme favorito: ");

        string? filme = Console.ReadLine();

        Movie filme1 = new Movie(filme, "Fantasia");

        Console.WriteLine(filme1);

    }
}







}