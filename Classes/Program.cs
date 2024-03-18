using Classes;

/*  
Person john = new Person();
john.firstName = "John";
john.lastName = "Smith";
*/

Person john = new()
{
    FirstName = "John",
    LastName = "Smith"
};

john.Introduce();
