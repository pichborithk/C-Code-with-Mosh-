public static class StringExtensions
{
    public static string Shorten(this string str, int numbereOfWords)
    {
        if (numbereOfWords == 0)
        {
            return "";
        }

        var words = str.Split(' ');

        if (words.Length <= numbereOfWords)
        {
            return str;
        }

        return string.Join(" ", words.Take(numbereOfWords) + "...");
    }
}