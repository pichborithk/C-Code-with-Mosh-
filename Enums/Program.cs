namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method1 = ShippingMethod.Express;
            Console.WriteLine(method1);
            Console.WriteLine((int) method1);

            var method2 = 1;
            Console.WriteLine((ShippingMethod) method2);

            var method3 = "Express";
            Console.WriteLine((int) Enum.Parse(typeof(ShippingMethod), method3));
            Console.WriteLine((ShippingMethod) Enum.Parse(typeof(ShippingMethod), method3));
        }
    }
}



