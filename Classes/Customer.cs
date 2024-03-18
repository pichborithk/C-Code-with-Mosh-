

namespace Classes
{
    /*
        internal class Customer(int id, string name)
        {
            public int Id = id;
            public string Name = name;
        }
    */
    internal class Customer
    {
        public int Id;
        public string Name;
        public List<string> Orders;

        public Customer()
        {
            this.Orders = [];
        }

        public Customer(int id, string name) : this()
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
