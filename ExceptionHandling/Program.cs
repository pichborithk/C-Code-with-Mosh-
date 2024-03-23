var calculator = new Calculator();
try
{
    var result = calculator.Divide(5, 0);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You cannot divide by 0");
}
catch (Exception e)
{
    Console.WriteLine("Sorry an unexpected error occurred.");
}

/* 
StreamReader? streamReader = null;
try
{
    streamReader = new StreamReader(@"c:\file.zip");
    var content = streamReader.ReadToEnd();
}
catch (Exception)
{
    Console.WriteLine("Sorry an unexpected error occurred.");
}
finally
{
    // if (streamReader != null)
    // {
    //     streamReader.Dispose();
    // }
    streamReader?.Dispose();
}
*/

/* 
try
{
    using (var streamReader = new StreamReader(@"c:\file.zip"))
    {
        var content = streamReader.ReadToEnd();
    }
}
catch (System.Exception)
{

    throw;
}
 */

try
{
    using var streamReader = new StreamReader(@"c:\file.zip");
    var content = streamReader.ReadToEnd();
}
catch (Exception)
{
    Console.WriteLine("Sorry an unexpected error occurred.");
}
