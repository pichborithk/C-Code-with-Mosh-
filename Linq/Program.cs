using Linq;

var books = new BookRepository().GetBooks();
/* 
    var cheapBooks = new List<Book>();
    foreach (var book in books)
    {
        if (book.Price < 10)
        {
            cheapBooks.Add(book);
        }
    }
 */
/* ---------------------------- Extension Methods --------------------------- */

/* 
    var cheapBooks = books.Where(book => book.Price < 10).OrderBy(book => book.Title);

    foreach (var book in cheapBooks)
    {
        Console.WriteLine(book.Title + " " + book.Price);
    }

    var bookTitles = cheapBooks.Select(book => book.Title);

    foreach (var title in bookTitles)
    {
        Console.WriteLine(title);
    }
 */

/* -------------------------- Linq Query Operators -------------------------- */
/* 
    var cheapBooks = from book in books
                    where book.Price < 10
                    orderby book.Title
                    select book;


    foreach (var book in cheapBooks)
    {
        Console.WriteLine(book.Title + " " + book.Price);
    }

    var bookTitles = from book in cheapBooks select book.Title;

    foreach (var title in bookTitles)
    {
        Console.WriteLine(title);
    }
 */

var book1 = books.Single(book => book.Title == "C# for Beginner");

Console.WriteLine(book1.Title);

var book2 = books.SingleOrDefault(book => book.Title == "C#");

Console.WriteLine("Book2 is null? {0}", book2 == null);

var anotherBooks = books.Skip(2).Take(2);

var maxPrice = books.Max(book => book.Price);
var average = books.Average(book => book.Price);
var total = books.Sum(book => book.Price);

