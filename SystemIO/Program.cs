var path = @"c:\Users\Pichborith Kong\Pictures\";

if (!Directory.Exists(path + "TestSystemIO"))
{
    Directory.CreateDirectory(path + "TestSystemIO");
}


if (File.Exists(path + @"\TestSystemIO\Wyven.jpg"))
{
    File.Delete(path + @"\TestSystemIO\Wyven.jpg");
}
File.Copy(path + "Wyven.jpg", path + @"\TestSystemIO\Wyven.jpg", true);

/*
    var fileInfo = new FileInfo(path + "Wyven.jpg");
    if (fileInfo.Exists)
    {
        fileInfo.CopyTo(path + @"\TestSystemIO\Wyven.jpg", true);
    }
*/
var files = Directory.GetFiles(path + "TestSystemIO", "*.*", SearchOption.AllDirectories);

foreach (var file in files)
{
    Console.WriteLine("Extension: " + Path.GetExtension(file));
    Console.WriteLine("File Name: " + Path.GetFileName(file));
    Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(file));
    Console.WriteLine("Directory Name: " + Path.GetDirectoryName(file));
    
}
/*
    var directories = Directory.GetDirectories(path);

    foreach (var d in directories) Console.WriteLine(d);
*/