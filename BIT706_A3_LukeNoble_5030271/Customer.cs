using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A3_LukeNoble_5030271
{
    public class Customer
    {
        private int customerId;
        private string name = "";
        private static int nextId = 1;

        public string Name { get => name; set => name = value; }
        public int CustomerId { get => customerId; }

        public Customer()
        {
            customerId = nextId;
            nextId++;
        }

        public Customer(string customerName) : this()
        {
            name = customerName;
        }

        public void EditCustomer(string newName)
        {
            name = newName;
        }
        public override string ToString()
        {
            return name;
        }

    }
}
