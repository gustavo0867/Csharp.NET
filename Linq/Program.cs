namespace LinqCode;

public class Program
{
    public static void Main()
    {
        var books = new List<Book>
      {
        new Book { title = "The Count of Monte Cristo", price = 39, publishYear = 2002 },
        new Book { title = "Brave new World ", price = 32, publishYear = 1932 },
        new Book { title = "The Hobbit", price = 35, publishYear = 2011 },
        new Book { title = "Pan's Labyrinth: The Labyrinth of the Faun", price = 25, publishYear = 2019 },
        new Book { title = "Throne of Glass", price = 29, publishYear = 2013 },
      };


        var livrosFiltrados = from book in books
                            where book.price > 30
                            select book.title; 

        foreach(var livro in livrosFiltrados)
        {
            Console.WriteLine(livro);
        }

        var novos = from book in books
                    select new
                    {
                        book.title, lengt = book.title.Length
                    };

        foreach(var novo in novos)
        {
            Console.WriteLine(novo);
        }



        var games = new List<List<string>>
        {
            new List<string> { "Valorant", "CS GO", "Battlefield" },
            new List<string> { "Need For Speed", "The crew" },
            new List<string> { "League of Legends", "Dota" }
        };

        var gamesInLine = from gameLine in games
                        from game in gameLine
                        select game;

        foreach(string game in gamesInLine)
        {
            Console.WriteLine(game);
        }
    
    }
}