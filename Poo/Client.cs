namespace teste
{
public class Movie
{
    private string _category;
    public string Ttitle { get; set; }
    public string Ccategory
    {
        get 
        {
            return "Categoria: " + _category;
        }
        set
        {
            if (value != "Fantasia" && value != "Ficção científica")
                throw new Exception("Categoria não permitida");

            _category = value;
        }
    }

    public Movie(string Title, string Category)
    {
        Ttitle = Title;
        Ccategory = Category;
    }


    public override string ToString() // Agora imprime detalhes corretamente
    {
        return $"Filme: {Ttitle}, {Ccategory}";
    }
}



}