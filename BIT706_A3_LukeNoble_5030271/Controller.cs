using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A3_LukeNoble_5030271
{
    /// <summary>
    /// Groups methods relating to the creation and editing of customers and accounts.
    /// Also handles methods relating to loading and saving binary data to file
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// An error message string to be updated when errors occur and can be displayed to user.
        /// </summary>
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// An info message string to be updated when messages are available to display to the user.
        /// </summary>
        public string? InfoMessage { get; set; }
        /// <summary>
        /// The fee for a failed transaction (Staff receive 50% discount)
        /// </summary>
        protected double fee = 10;
        /// <summary>
        /// The current interest rate in whole percentages
        /// </summary>
        protected double interest = 4; // 4%
        /// <summary>
        /// The overdraft limit on overdraft accounts (Currently only Omni accounts)
        /// </summary>
        protected double overdraftLimit = 100;
        /// <summary>
        /// A record of the last transaction
        /// </summary>
        protected string? LastTransaction { get; set; }
        /// <summary>
        /// The currently selected customer object
        /// </summary>
        public Customer? cust { get; set; }

        /// <summary>
        /// Creates a new customer with three accounts and adds the customer object to the list of customers
        /// </summary>
        /// <param name="name">The name of the new customer</param>
        /// <param name="staffMember">whether they are a staff member or not (true/false)</param>
        public void CreateCustomer(string name, bool staffMember)
        {

            ResetMessages();
            if (name.Any(char.IsDigit))
            {
                ErrorMessage = "Name cannot contain numbers";
            }
            else
            {
                try
                {
                    Customer customer = new Customer(name, staffMember);
                    customer.AddAccount(new Everyday(0));
                    customer.AddAccount(new Investment(0, fee, interest));
                    customer.AddAccount(new Omni(0, fee, interest, overdraftLimit));
                    addCustomerToList(customer);
                    InfoMessage = "New customer: " + name + " added with customerId of: " + FindCustomerByName(name).CustomerId;
                }
                catch
                {
                    ErrorMessage = "Unable to add customer";
                }
            }
        }
        /// <summary>
        /// Adds Customer to BankData Customer list
        /// </summary>
        /// <param name="customer">Customer object</param>
        public void addCustomerToList(Customer customer)
        {
            BankData.AddCustomer(customer);
        }
        /// <summary>
        /// Gets a list of all customers
        /// </summary>
        /// <returns>AllCustomers List</returns>
        public List<Customer> getCustomerList()
        {
            return BankData.AllCustomers;
        }

        /// <summary>
        /// Uses customer id to search for matching customer in customer list
        /// </summary>
        /// <param name="value">Customer Id value</param>
        /// <returns>Customer object with matching id or null</returns>
        public Customer? FindCustomerById(int value)
        {
            foreach (Customer customer in getCustomerList())
            {
                if (customer.CustomerId == value)
                {
                    return customer;
                }
            }
            return null;
        }

        /// <summary>
        /// Users customer name to search for matching customer in customer list
        /// </summary>
        /// <param name="value">Customer name</param>
        /// <returns>Customer object with matching name or null</returns>
        public Customer? FindCustomerByName(string value)
        {
            foreach (Customer customer in getCustomerList())
            {
                if (customer.Name == value)
                {
                    return customer;
                }
            }
            return null;
        }

        /// <summary>
        /// Updates customer name
        /// </summary>
        /// <param name="cust">Customer object being edited (taken from cust in Controller class)</param>
        /// <param name="name">New name for customer</param>
        public void EditCustomer(Customer cust, string name)
        {
            ResetMessages();
            if (name.Any(char.IsDigit))
            {
                ErrorMessage = "Name cannot contain numbers";
            }
            else
            {
                try
                {
                    cust.Name = name;
                    InfoMessage = cust.Name + " has been edited";
                }
                catch
                {
                    ErrorMessage = "Unable to edit customer";
                }
            }

        }

        /// <summary>
        /// removes a customer from the AllCustomers list
        /// </summary>
        /// <param name="customer">Customer object to be removed</param>
        public void DeleteCustomer(Customer customer)
        {
            ResetMessages();
            try
            {
                BankData.AllCustomers.Remove(customer);
                InfoMessage = "Customer \'" + customer.Name + "\' has been deleted.";
            }
            catch
            {
                ErrorMessage = "Unable to delete customer";
            }
        }

        /// <summary>
        /// Resets all messages to null
        /// </summary>
        public void ResetMessages()
        {
            InfoMessage = "";
            ErrorMessage = "";
        }
        /// <summary>
        /// deposits an amount into a customers account
        /// </summary>
        /// <param name="acc">Account Object recieving deposit</param>
        /// <param name="amount">the amount to be deposited</param>
        public void deposit(Account acc, double amount)
        {
            acc.Deposit(amount);
            LastTransaction = acc.GetLastTransaction();
        }
        /// <summary>
        /// Attempts to withdraw an amount from a selected account. Creates error message if failed
        /// </summary>
        /// <param name="acc">The selected account to withdraw from</param>
        /// <param name="amount">The ammount to be withdrawn</param>
        public void withdraw(Account acc, double amount)
        {
            try
            {
                acc.Withdraw(amount, cust.IsStaff);
                LastTransaction = acc.GetLastTransaction();

            }
            catch (AccountWithdrawlFailedException ex)
            {
                ErrorMessage = ex.Message;
                LastTransaction = ex.Message;
            }
            
        }
        /// <summary>
        /// Adds interest on selected account based on accounts interest rate.
        /// </summary>
        /// <param name="acc">The selected account to gain interest</param>
        public void addInterest(Account acc)
        {
            try
            {
                acc.AddInterest();
                LastTransaction = acc.GetLastTransaction();
            }
            catch (AccountAddInterestFailedException ex)
            {
                ErrorMessage = ex.Message;
                LastTransaction = ex.Message;
            }
        }
        /// <summary>
        /// Handles the transfer of funds from one account to another. By running the withdraw and deposit methods
        /// </summary>
        /// <param name="fromAccount">the account to transfer funds from</param>
        /// <param name="toAccount">the account to transfer funds to</param>
        /// <param name="amount">The amount to be transfered</param>
        public void handleTransfer(Account fromAccount, Account toAccount, double amount)
        {
            try
            {
                fromAccount.Withdraw(amount, cust.IsStaff);
                toAccount.Deposit(amount);
            }
            catch (AccountWithdrawlFailedException ex)
            {
                ErrorMessage = "Insufficient funds to make transfer";
                LastTransaction = ErrorMessage;
            }

        }
        /// <summary>
        /// Gets the last transaction string data
        /// </summary>
        /// <returns>The last transaction string</returns>
        public string getLastTransaction()
        {
            return LastTransaction;
        }
        /// <summary>
        /// Adds an account based on the selected account type to the existing customer reference (Controller.cust)
        /// </summary>
        /// <param name="accountType">The account type string description</param>
        /// <exception cref="AddAccountFailedException">Thrown if an account failed to be created</exception>
        public void addAccount(string accountType)
        {
            if (accountType == "Everyday Account") cust.AddAccount(new Everyday(0));
            else if (accountType == "Investment Account") cust.AddAccount(new Investment(0, fee, interest));
            else if (accountType == "Omni Account") cust.AddAccount(new Omni(0, fee, interest, overdraftLimit));
            else
            {
                throw new AddAccountFailedException("Unable to create a new account");
            }
        }
        /// <summary>
        /// Writed BankData to a binary file on application close
        /// </summary>
        public void WriteBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("../../BankData.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, BankData.getInstance());

            stream.Close();
        }

        /// <summary>
        /// reads and loads BankData from binary file on application start
        /// </summary>
        public void ReadBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../BankData.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            BankData.setInstance((BankData)formatter.Deserialize(stream));
            stream.Close();
        }
    }
}
