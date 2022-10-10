using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A3_LukeNoble_5030271
{
    //Account class
    [Serializable]
    public abstract class Account
    {
        protected double balance;
        public double Balance { get => balance; set => balance = value; }
        protected string lastTransaction = "";
        protected string type = "";
        protected int accountID;

        //Constructors
        protected Account()
        {
            accountID = BankData.NextAccountId;
        }
        protected Account(double Balance, string AccountType) : this()
        {
            balance = Balance;
            type = AccountType;
        }
        // Sets virtual methods 
        public virtual double Fee()
        {
            return 0;
        }
        public virtual string Info()
        {
            return "Account Type: " + type + "\n"
                + "Balance: $" + balance;
        }
        // Sets abstract methods
        public abstract void AddInterest();
        public abstract string AccountType();
        public abstract void Withdraw(double amount, bool isStaff);
        public abstract void Deposit(double amount);
        public abstract double AvailableFunds();

        //returns last transaction
        public string GetLastTransaction()
        {
            return lastTransaction;
        }
    }

    /*
     * Everyday Account Class
     */
    [Serializable]
    public class Everyday : Account
    {
        // Constructor
        public Everyday(double Balance) : base(Balance, "Everyday") { }

        // Returns account type
        public override string AccountType()
        {
            return type;
        }

        // returns id, account type and account balance
        public override string ToString()
        {
            return accountID + ": " + type + ": " + balance;
        }

        // Checks for available funds, withdraws if successful and sets last transaction, sets error transaction if insufficient funds
        public override void Withdraw(double amount, bool isStaff)
        {
            if (balance >= amount)
            {
                balance -= amount;
                lastTransaction = type + " " + accountID + "; withdrawal $" + amount
                    + "; transaction succeeded; \nNew Balance: $" + balance;
            }
            else
            {
                lastTransaction = type + " " + accountID + "; withdrawal $" + amount
                    + "; transaction failed";
                throw new AccountWithdrawlFailedException(type + " " + accountID + "; withdrawal $" + amount + "; transaction failed");

            }
        }
        // Adds deposit amount to balance, sets last transaction
        public override void Deposit(double amount)
        {
            balance += amount;
            lastTransaction = type + " " + accountID + "; deposit $" + amount
                + "; \nNew balance: $" + balance;
        }
        // Alerts user that Everyday account cannot add interest, sets last transaction
        public override void AddInterest()
        {
            lastTransaction = "Transaction Failed: Interest cannot be added to an Everyday Bank Account!";
            throw new AccountAddInterestFailedException("Interest cannot be added to an Everyday Bank Account!");
        }

        public override double AvailableFunds()
        {
            return balance;
        }
    }

    /*
     * Investment Account Class
     */
    [Serializable]
    public class Investment : Account
    {
        // initialises attributes
        protected double fee;
        protected double interestRate;

        // Constructor
        public Investment(double balance, double Fee, double InterestRate) : base(balance, "Investment")
        {
            fee = Fee;
            interestRate = InterestRate;
        }
        // Returns account type
        public override string AccountType()
        {
            return type;
        }
        // returns id, account type and account balance
        public override string ToString()
        {
            return accountID + ": " + type + ": " + balance;
        }
        // returns account fee
        public override double Fee()
        {
            return fee;
        }

        // returns base info data on account id, type and balance and adds fee an interest rate
        public override string Info()
        {
            return base.Info() + "\n"
                + "Fee: $" + fee + "\n"
                + "Interest Rate: " + interestRate + "%";
        }
        // Checks for available funds, withdraws if successful and sets last transaction, sets error transaction if insufficient funds and charges fee
        public override void Withdraw(double amount, bool isStaff)
        {
            if (balance >= amount)
            {
                balance -= amount;
                lastTransaction = type + " " + accountID + "; withdrawal $" + amount
                    + "; transaction succeeded; \nNew Balance: $" + balance;
            }
            else
            {
                double tempFee = fee;
                if (isStaff) tempFee = (fee / 2);
                balance -= tempFee;
                lastTransaction = type + " " + accountID + "; withdrawal $" + amount
                    + "; transaction failed; fee: $" + tempFee + "; \nNew balance: $" + balance;
                throw new AccountWithdrawlFailedException(type + " " + accountID + "; withdrawal $" + amount
                    + "; transaction failed; fee: $" + tempFee + "; \nNew balance: $" + balance);
            }
        }
        // Adds deposit amount to balance, sets last transaction
        public override void Deposit(double amount)
        {
            balance += amount;
            lastTransaction = type + " " + accountID + "; deposit $" + amount
                + "; \nNew balance: $" + balance;
        }
        // Calculates and adds interest based on interest rate, sets last transaction
        public override void AddInterest()
        {
            double interest = Math.Round(balance * (interestRate / 100), 2);
            balance += interest;
            lastTransaction = type + " " + accountID + "; Add interest $" + interest + "; balance $" + balance;
        }
        public override double AvailableFunds()
        {
            return balance;
        }
    }

    /*
     * Omni Account Class
     */
    [Serializable]
    public class Omni : Account
    {
        // initialises attributes
        protected double fee;
        protected double interestRate;
        protected double overdraftLimit;

        // Constructor
        public Omni(double balance, double Fee, double InterestRate, double OverdraftLimit) : base(balance, "Omni")
        {
            fee = Fee;
            interestRate = InterestRate;
            overdraftLimit = OverdraftLimit;
        }
        // Returns account type
        public override string AccountType()
        {
            return type;
        }
        // returns id, account type and account balance
        public override string ToString()
        {
            return accountID + ": " + type + ": " + balance;
        }
        // returns account fee
        public override double Fee()
        {
            return fee;
        }
        // returns base info data on account id, type and balance and adds fee, interest rate and overdraft limit
        public override string Info()
        {
            return base.Info() + "\n"
                + "Fee: $" + fee + "\n"
                + "Interest Rate: " + interestRate + "%" + "\n"
                + "Overdraft Limit: $" + overdraftLimit;
        }
        // Checks for available funds, withdraws if successful and sets last transaction, sets error transaction if insufficient funds and charges fee
        public override void Withdraw(double amount, bool isStaff)
        {
            if (balance + overdraftLimit >= amount)
            {
                balance -= amount;
                lastTransaction = type + " " + accountID + "; Overdraft Limit: $" + overdraftLimit + "; withdrawal $" + amount
                    + "; transaction succeeded; \nNew Balance: $" + balance;
            }
            else
            {
                double tempFee = fee;
                if (isStaff) tempFee = (fee / 2);
                balance -= tempFee;
                lastTransaction = type + " " + accountID + "; Overdraft Limit: $" + overdraftLimit + "; withdrawal $" + amount
                    + "; transaction failed; fee: $" + tempFee + "; \nNew balance: $" + balance;
                throw new AccountWithdrawlFailedException(type + " " + accountID + "; Overdraft Limit: $" + overdraftLimit + "; withdrawal $" + amount
                    + "; transaction failed; fee: $" + tempFee + "; \nNew balance: $" + balance);
            }
        }
        // Adds deposit amount to balance, sets last transaction
        public override void Deposit(double amount)
        {
            balance += amount;
            lastTransaction = type + " " + accountID + "; deposit $" + amount
                + "; \nNew balance: $" + balance;
        }
        // Calculates and adds interest based on interest rate, sets last transaction
        public override void AddInterest()
        {
            if (balance >= 0)
            {
                double interest = Math.Round(balance * (interestRate / 100), 2);
                balance += interest;
                lastTransaction = type + " " + accountID + "; Add interest $" + interest + "; balance $" + balance;
            }
            else
            {
                MessageBox.Show(type + " " + accountID + " Transaction Failed: interest cannot be added when balance is less than 0", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastTransaction = type + " " + accountID + " Transaction Failed: interest cannot be added when balance is less than 0";
            }

        }

        public override double AvailableFunds()
        {
            return balance + overdraftLimit;
        }
    }
}
