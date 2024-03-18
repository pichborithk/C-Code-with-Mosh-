using Classes;

/*  
Person john = new Person();
john.firstName = "John";
john.lastName = "Smith";
*/

Person john = new(new DateTime(1989, 11, 26))
{
    FirstName = "John",
    LastName = "Smith"
};

john.Introduce();
Console.WriteLine("John age is " + john.Age);
