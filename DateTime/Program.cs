var dataTime = new DateTime(2024, 1, 1);

Console.WriteLine(dataTime.ToString());

var today = DateTime.Today;

Console.WriteLine("Current Date: " + today.Date);

var now = DateTime.Now;

Console.WriteLine("Current Hour: " + now.Hour);

/*
    Console.WriteLine(now.ToLongDateString());
    Console.WriteLine(now.ToShortDateString());
    Console.WriteLine(now.ToLongTimeString());
    Console.WriteLine(now.ToShortTimeString());
    Console.WriteLine(now.ToString("yyyy-MM-dd"));
*/

var tomorrow = today.AddDays(1);

Console.WriteLine("Tomorrow is: " + tomorrow.ToString());

var yesterday = today.AddDays(-1);

Console.WriteLine("Yesterday is: " + yesterday.ToString());
