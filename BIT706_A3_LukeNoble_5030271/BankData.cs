using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A3_LukeNoble_5030271
{
    [Serializable]
    public class BankData
    {
        private int nextCustomerId = 0;
        private int nextAccountId = 0;
        protected List<Customer> allCustomers = new List<Customer>();
        private static BankData myInstance;
        
        private BankData() { }

        public static BankData getInstance()
        {
            if (myInstance == null)
            {
                myInstance = new BankData();
            }
            return myInstance;
        }
        public static void setInstance(BankData bd)
        {
            myInstance = bd;
        }

        public static int NextCustomerId
        {
            get
            {
                myInstance.nextCustomerId++;
                return myInstance.nextCustomerId;
            }
        }

        public static int NextAccountId
        {
            get
            {
                myInstance.nextAccountId++;
                return myInstance.nextAccountId;
            }
        }
        public static List<Customer> AllCustomers
        {
            get
            {
                return myInstance.allCustomers;
            }
            set
            {
                myInstance.allCustomers = value;
            }
        }
        public static void AddCustomer(Customer customer)
        {
            myInstance.allCustomers.Add(customer);

        }
    }
}
