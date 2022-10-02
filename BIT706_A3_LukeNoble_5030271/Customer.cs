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
        private bool isStaff;
        public List<Account> AllAccounts = new List<Account>();

        public string Name { get => name; set => name = value; }
        public int CustomerId { get => customerId; }
        public bool IsStaff { get => isStaff; set => isStaff = value; }

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
        public void AddAccount(Account account)
        {
            AllAccounts.Add(account);
        }
        public override string ToString()
        {
            return name;
        }

    }
}
