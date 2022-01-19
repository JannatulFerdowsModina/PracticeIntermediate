using System.Collections.Generic;

namespace PracticeIntermediate
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
        {
            Id = id;
        }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;

        }
    }
}
