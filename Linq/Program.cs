namespace LinqCode;

public class Program
{
    public static void Main()
    {
        /*var books = new List<Book>
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


        List<Author> authors = new List<Author>
        {
            new Author { Id = 1, Name = "Clarice Lispector"},
            new Author { Id = 2, Name = "Jorge Amado" }
        };

        List <Book> books = new List<Book>
        {
            new Book { Name = "Capitães da Areia", AuthorId = 2},
            new Book { Name = "Água Viva", AuthorId = 1},
            new Book { Name = "A hora da Estrela", AuthorId = 1},
            new Book { Name = "Cacau", AuthorId = 2},
        };

        var livrosENomes = from autor in authors
                            from book in books
                                where autor.Id == book.AuthorId
                                    orderby autor.Name descending
                                        select new BooKDto {NameAuthor = autor.Name , NameBook = book.Name};
        
        foreach (BooKDto livro in livrosENomes)
        {
            Console.WriteLine(livro.NameAuthor + " Nome livro " + livro.NameBook);
        }


    
    }

    public class Author {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Book {
        public string? Name { get; set; }
        public int AuthorId { get; set;}
    }

    public class BooKDto
    {
        public string? NameAuthor {get; set;}

        public string? NameBook {get; set;}
    }*/


    Developer Julia = new Developer { FirstName = "Julia", LastName = "Santos" };
    Developer Paulo = new Developer { FirstName = "Paulo", LastName = "Oliveira" };
    Developer Rebeca = new Developer { FirstName = "Rebeca", LastName = "Silva" };
    Developer Rodrigo = new Developer { FirstName = "Rodrigo", LastName = "Alves" };
    Developer Joana = new Developer { FirstName = "Joana", LastName = "Batista" };
    Developer Alan = new Developer { FirstName = "Alan", LastName = "Martins" };

    Language csharp = new Language { Name = "C#" };
    Language java = new Language { Name = "Java" };
    Language js = new Language { Name = "Javascript" };

    Database mysql = new Database { Name = "MySQL"};
    Database sqlserver = new Database { Name = "SQL Server"};

    List<DeveloperLanguages> developerLanguages = new List<DeveloperLanguages>
    {
        new DeveloperLanguages { developer = Julia, language = csharp},
        new DeveloperLanguages { developer = Julia, language = java},
        new DeveloperLanguages { developer = Paulo, language = js},
        new DeveloperLanguages { developer = Rebeca, language = java},
        new DeveloperLanguages { developer = Rodrigo, language = csharp},
        new DeveloperLanguages { developer = Rodrigo, language = js},
        new DeveloperLanguages { developer = Joana, language = csharp},
        new DeveloperLanguages { developer = Alan, language = js}
    };

    List<DeveloperDatabases> developerDatabases = new List<DeveloperDatabases>
    {
        new DeveloperDatabases { developer = Julia, database = mysql},
        new DeveloperDatabases { developer = Julia, database = sqlserver},
        new DeveloperDatabases { developer = Paulo, database = mysql},
        new DeveloperDatabases { developer = Rebeca, database = mysql},
        new DeveloperDatabases { developer = Rodrigo, database = sqlserver},
        new DeveloperDatabases { developer = Joana, database = mysql},
        new DeveloperDatabases { developer = Alan, database = mysql},
        new DeveloperDatabases { developer = Alan, database = sqlserver},
    };

    var developerSkills = from developerLanguage in developerLanguages
                              join developerDatabase in developerDatabases 
                              on developerLanguage.developer equals developerDatabase.developer
                              select new {
                                DeveloperName = developerLanguage.developer.FirstName + " " + developerLanguage.developer.LastName,
                                Language = developerLanguage.language.Name,
                                Database = developerDatabase.database.Name
                              };

        foreach(var obj in developerSkills)
        {
            Console.WriteLine("Developer " + obj.DeveloperName 
                + " can develop a project using " + obj.Language 
                + " and " + obj.Database);
        }



    }

    public class Developer {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    public class Language {
        public string? Name { get; set; }
    }

    public class Database {
        public string? Name { get; set; }
    }

    public class DeveloperLanguages {
        public Developer? developer;
        public Language? language;
    }

    public class DeveloperDatabases {
        public Developer? developer;
        public Database? database;
    }





}