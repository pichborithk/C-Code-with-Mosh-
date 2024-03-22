// Nullable<DateTime> date = null;
DateTime? date = null;

Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
Console.WriteLine("HasValue: " + date.HasValue);
/* 
DateTime date2;

if (date != null)
{
    date2 = date.GetValueOrDefault();
}
else
{
    date2 = DateTime.Today;
}
 */

// DateTime date2 = date != null ? date.GetValueOrDefault() : DateTime.Today;
DateTime date2 = date ?? DateTime.Today;

Console.WriteLine(date2);