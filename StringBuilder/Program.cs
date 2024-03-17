using System.Text;

var builder = new StringBuilder();
builder.Append('-', 10).AppendLine();

builder.Append("Header");
builder.AppendLine();
builder.Append('-', 10);
Console.WriteLine(builder);
builder.Replace('-', '+');

Console.WriteLine(builder);

//builder.Remove(0, 10);
builder.Insert(10, new string('-', 10));

Console.WriteLine(builder); 
