

public class Book
{
    public string Title { get; set; }
    public float Price { get; set; }
}

var books = new BookRepository().GetBooks();