public class BookRepository
{
    public List<Book> GetBook()
    {
        return new List<Book>
        {
            new Book() {Title = "Title 1", Price = 5},
            new Book() {Title = "Title 2", Price = 7},
            new Book() {Title = "Title 3", Price = 17},
        };
    }
}