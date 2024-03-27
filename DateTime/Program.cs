// Get the current date and time
DateTime currentDate = DateTime.Now;
Console.WriteLine("Current Date and Time: " + currentDate);

// Get the current date without time
DateTime todayDate = DateTime.Today;
Console.WriteLine("Today's Date: " + todayDate);

// Create a specific date and time
DateTime customDate = new DateTime(2024, 3, 26, 14, 30, 0); // Year, Month, Day, Hour, Minute, Second
Console.WriteLine("Custom Date and Time: " + customDate);

// Get individual components of a DateTime object
int year = currentDate.Year;
int month = currentDate.Month;
int day = currentDate.Day;
int hour = currentDate.Hour;
int minute = currentDate.Minute;
int second = currentDate.Second;

Console.WriteLine("\nIndividual Components:");
Console.WriteLine("Year: " + year);
Console.WriteLine("Month: " + month);
Console.WriteLine("Day: " + day);
Console.WriteLine("Hour: " + hour);
Console.WriteLine("Minute: " + minute);
Console.WriteLine("Second: " + second);

// Add and subtract days, hours, minutes, etc.
DateTime futureDate = currentDate.AddDays(10);
DateTime pastDate = currentDate.AddMonths(-1);

Console.WriteLine("\nFuture Date (10 days later): " + futureDate);
Console.WriteLine("Past Date (1 month ago): " + pastDate);

// Compare DateTime objects
DateTime date1 = new DateTime(2024, 3, 26);
DateTime date2 = new DateTime(2024, 3, 27);

int result = DateTime.Compare(date1, date2);
if (result < 0)
{
    Console.WriteLine("\n" + date1 + " is earlier than " + date2);
}
else if (result > 0)
{
    Console.WriteLine("\n" + date1 + " is later than " + date2);
}
else
{
    Console.WriteLine("\n" + date1 + " and " + date2 + " are equal");
}


/*
    Console.WriteLine(now.ToLongDateString());
    Console.WriteLine(now.ToShortDateString());
    Console.WriteLine(now.ToLongTimeString());
    Console.WriteLine(now.ToShortTimeString());
    Console.WriteLine(now.ToString("yyyy-MM-dd"));
*/

var tomorrow = todayDate.AddDays(1);

Console.WriteLine("Tomorrow is: " + tomorrow.ToString());

var yesterday = todayDate.AddDays(-1);

Console.WriteLine("Yesterday is: " + yesterday.ToString());
