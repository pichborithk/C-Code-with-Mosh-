
public class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        /*
            return new List<Book> {
                new Book(){Title = "ASP.NET MVC", Price = 9.99f},
                new Book(){Title = "ASP.NET Web API", Price = 12},
                new Book(){Title = "C# Beginner Topics", Price = 7},
                new Book(){Title = "C# Advanced Topics", Price = 9}
            };
        */
        return [
            new Book(){Title = "ASP.NET MVC", Price = 9.99f},
            new Book(){Title = "ASP.NET Web API", Price = 12},
            new Book(){Title = "C# Beginner Topics", Price = 7},
            new Book(){Title = "C# Advanced Topics", Price = 9}
        ];
    }
}
