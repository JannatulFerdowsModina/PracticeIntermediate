using System.Collections.Generic;

namespace PracticeIntermediate
{
    public class ReadOnly
    {
        public readonly List<Order> Orders = new List<Order>();
        public void Promote()
        {
            // Orders = new List<Order>();
        }
    }
}
