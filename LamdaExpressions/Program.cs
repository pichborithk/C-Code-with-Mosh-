/*
    static int Square(int number)
    {
        return number * number;
    }
*/

// Func<int, int> square = Square;
Func<int, int> square = number => number * number;

// Console.WriteLine(Square(3));
Console.WriteLine(square(3));

var books = new BookRepository().GetBook();

// var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
var cheapBooks = books.FindAll(book => book.Price < 10);

foreach (var book in cheapBooks) Console.WriteLine(book.Title);

/*
    static bool IsCheaperThan10Dollars(Book book)
    {
        return book.Price < 10;
    }
*/