using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A3_LukeNoble_5030271
{
    public class Controller
    {
        public string ErrorMessage { get; set; }
        public string? InfoMessage { get; set; }
        public Customer? cust { get; set; }
        public List<Customer> AllCust = new List<Customer>();

        // Create new Customer and add to AllCust list. Create info or error messages
        public void CreateCustomer(string name)
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
                    AllCust.Add(new Customer(name));
                    InfoMessage = "New customer: " + name + " added with customerId of: " + FindCustomerByName(name).CustomerId;
                }
                catch
                {
                    ErrorMessage = "Unable to add customer";
                }
            }
        }

        // Recieves customer id int and returns Customer object with that CustomerId
        public Customer? FindCustomerById(int value)
        {
            foreach (Customer customer in AllCust)
            {
                if (customer.CustomerId == value)
                {
                    return customer;
                }
            }
            return null;
        }

        // Recieves customer name string and returns Customer object with that name
        public Customer? FindCustomerByName(string value)
        {
            foreach (Customer customer in AllCust)
            {
                if (customer.Name == value)
                {
                    return customer;
                }
            }
            return null;
        }

        // Receives customer object and name. Attempts to update customer's name. Creates appropriate return message
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
                    InfoMessage = cust.Name + "'s name has been edited";
                }
                catch
                {
                    ErrorMessage = "Unable to edit customer";
                }
            }

        }

        // Receives customer object. Attempts to delete customer. Creates appropriate return message
        public void DeleteCustomer(Customer cust)
        {
            ResetMessages();
            try
            {
                AllCust.Remove(cust);
                InfoMessage = "Customer \'" + cust.Name + "\' has been deleted.";
            }
            catch
            {
                ErrorMessage = "Unable to delete customer";
            }
        }

        // Resets all message types to avoid error messages enduring on UI
        public void ResetMessages()
        {
            InfoMessage = "";
            ErrorMessage = "";
        }
    }
}
