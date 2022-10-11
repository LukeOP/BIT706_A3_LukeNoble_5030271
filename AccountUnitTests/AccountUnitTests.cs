using BIT706_A3_LukeNoble_5030271;

namespace AccountUnitTests
{
    [TestClass]
    public class AccountUnitTests
    {
        Controller control = new Controller();
        Customer customer;
        Account AccountEveryday;
        Account InvestmentAccount;
        Account OmniAccount;
        [TestInitialize]
        public void Initialize()
        {
            BankData.getInstance();
            control.CreateCustomer("Sam", false);
            customer = control.FindCustomerByName("Sam");

            customer.Accounts[0].Balance = 12;
            customer.Accounts[1].Balance = 1000;
            customer.Accounts[2].Balance = 2500;

            AccountEveryday = customer.Accounts[0];
            InvestmentAccount = customer.Accounts[1];
            OmniAccount = customer.Accounts[2];
        }

        [TestMethod]
        public void Account_Create_Account()
        {
            Everyday edAccount = new Everyday(500);
            double expected = 500;
            double actual = edAccount.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_Get_Account_Type()
        {
            String expected = "Everyday";
            String actual = AccountEveryday.AccountType();
            Assert.AreEqual(expected, actual);

            expected = "Investment";
            actual = InvestmentAccount.AccountType();
            Assert.AreEqual(expected, actual);

            expected = "Omni";
            actual = OmniAccount.AccountType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_Get_Fee()
        {
            double expected = 10;
            double actual = InvestmentAccount.Fee();
            Assert.AreEqual(expected, actual);

            expected = 10;
            actual = OmniAccount.Fee();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_Get_Info()
        {
            string expected = "Account Type: Everyday\nBalance: $12";
            string actual = AccountEveryday.Info();
            Assert.AreEqual(expected, actual);

            expected = "Account Type: Investment\nBalance: $1000\nFee: $10\nInterest Rate: 4%";
            actual = InvestmentAccount.Info();
            Assert.AreEqual(expected, actual);

            expected = "Account Type: Omni\nBalance: $2500\nFee: $10\nInterest Rate: 4%\nOverdraft Limit: $100";
            actual = OmniAccount.Info();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_Withdraw_Success()
        {
            int amount = 10;

            string expected = "Account Type: Everyday\nBalance: $2";
            AccountEveryday.Withdraw(amount, false);
            string actual = AccountEveryday.Info();
            Assert.AreEqual(expected, actual);

            expected = "Account Type: Investment\nBalance: $990\nFee: $10\nInterest Rate: 4%";
            InvestmentAccount.Withdraw(amount, false);
            actual = InvestmentAccount.Info();
            Assert.AreEqual(expected, actual);

            expected = "Account Type: Omni\nBalance: $2490\nFee: $10\nInterest Rate: 4%\nOverdraft Limit: $100";
            OmniAccount.Withdraw(amount, false);
            actual = OmniAccount.Info();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_Withdraw_Throws_Exception_When_Amount_Exceeds_Balance_And_Overdraft()
        {
            int amount = 5000;
            Assert.ThrowsException<AccountWithdrawlFailedException>(() => AccountEveryday.Withdraw(amount, false));
            Assert.ThrowsException<AccountWithdrawlFailedException>(() => InvestmentAccount.Withdraw(amount, false));
            Assert.ThrowsException<AccountWithdrawlFailedException>(() => OmniAccount.Withdraw(amount, false));
        }

        [TestMethod]
        public void Account_Deposit()
        {
            int amount = 10;

            string expected = "Account Type: Everyday\nBalance: $22";
            AccountEveryday.Deposit(amount);
            string actual = AccountEveryday.Info();
            Assert.AreEqual(expected, actual);

            expected = "Account Type: Investment\nBalance: $1010\nFee: $10\nInterest Rate: 4%";
            InvestmentAccount.Deposit(amount);
            actual = InvestmentAccount.Info();
            Assert.AreEqual(expected, actual);

            expected = "Account Type: Omni\nBalance: $2510\nFee: $10\nInterest Rate: 4%\nOverdraft Limit: $100";
            OmniAccount.Deposit(amount);
            actual = OmniAccount.Info();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_Add_Interest()
        {
            string expected = "Account Type: Investment\nBalance: $1040\nFee: $10\nInterest Rate: 4%";
            InvestmentAccount.AddInterest();
            string actual = InvestmentAccount.Info();
            Assert.AreEqual(expected, actual);

            expected = "Account Type: Omni\nBalance: $2600\nFee: $10\nInterest Rate: 4%\nOverdraft Limit: $100";
            OmniAccount.AddInterest();
            actual = OmniAccount.Info();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_Add_Interest_Thow_Exception()
        {
            Assert.ThrowsException<AccountAddInterestFailedException>(() => AccountEveryday.AddInterest());
        }

        [TestMethod]
        public void Delete_Customer()
        {
            control.CreateCustomer("stuart", false);
            Customer thisCustomer = control.FindCustomerByName("stuart");
            control.DeleteCustomer(thisCustomer);
        }
    }
}