using System.Net.NetworkInformation;

string post = "This is supposed to be a very long blog post...";
var shortenPost = post.Shorten(5);

Console.WriteLine(shortenPost);
