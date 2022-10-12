using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A3_LukeNoble_5030271
{
    [Serializable]
    public class Customer
    {
        private int customerId;
        private string name = "";
        private bool isStaff = false;
        private List<Account> allAccounts = new List<Account>();

        public string Name { get => name; set => name = value; }
        public int CustomerId { get => customerId; }
        public bool IsStaff { get => isStaff; set => isStaff = value; }
        public List<Account> Accounts { get => allAccounts; }

        public Customer()
        {
            customerId = BankData.NextCustomerId;
        }

        public Customer(string customerName) : this()
        {
            name = customerName;
        }

        public Customer(string customerName, bool IsStaff) : this(customerName)
        {
            isStaff = IsStaff;
        }

        public void EditCustomer(string newName, bool staff)
        {
            name = newName;
            isStaff = staff;
        }
        public void AddAccount(Account account)
        {
            allAccounts.Add(account);
        }
        public override string ToString()
        {
            return CustomerId + " " + name;
        }

    }
}
