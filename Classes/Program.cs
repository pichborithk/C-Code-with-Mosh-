

namespace Classes
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
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
        }
    }
}
