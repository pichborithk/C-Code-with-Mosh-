using Classes;

/*  
Person john = new Person();
john.firstName = "John";
john.lastName = "Smith";
*/

Person john = new()
{
    firstName = "John",
    lastName = "Smith"
};

john.Introduce();
