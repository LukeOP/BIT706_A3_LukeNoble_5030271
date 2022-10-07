using BIT706_A3_LukeNoble_5030271;
using System;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class AccountTransfers
    {

        Controller control = new Controller();
        Account selectedAccount;
        Account everyday_account;
        Account intestment_account;

        [Given(@"there is an instance of BankData")]
        public void GivenThereIsAnInstanceOfBankData()
        {
            BankData.getInstance();
            BankData.AllCustomers.Clear();
            Assert.Equal(0, BankData.AllCustomers.Count);
        }

        [Given(@"a user exists with accounts")]
        public void GivenAUserExistsWithAccounts()
        {
            control.CreateCustomer("John", false);
            control.cust = control.FindCustomerByName("John");
            Assert.Equal(1, BankData.AllCustomers.Count);
        }

        [Given(@"an account is selected")]
        public void GivenAnAccountIsSelected()
        {
            selectedAccount = control.cust.Accounts[0];
        }

        [When(@"a deposit of (.*) is made")]
        public void WhenADepositOfIsMade(int p0)
        {
            selectedAccount.Deposit(p0);
        }

        [Then(@"the balance has increased by (.*)")]
        public void ThenTheBalanceHasIncreasedBy(int p0)
        {
            Assert.Equal(p0, selectedAccount.Balance);
        }

        [Given(@"an account to transfer from has (.*) dollars")]
        public void GivenAnAccountToTransferFromHasDollars(double p0)
        {
            control.cust.Accounts[0].Balance = p0;
            Assert.Equal(p0, control.cust.Accounts[0].Balance);
        }

        [Given(@"and account to transfer to has (.*) dollars")]
        public void GivenAndAccountToTransferToHasDollars(double p0)
        {
            control.cust.Accounts[1].Balance = p0;
            Assert.Equal(p0, control.cust.Accounts[1].Balance);
        }

        [When(@"a transfer of (.*) dollars occurs")]
        public void WhenATransferOfDollarsOccurs(double p0)
        {
            control.handleTransfer(control.cust.Accounts[0], control.cust.Accounts[1], p0);
        }

        [Then(@"the from account balance will be (.*) dollars")]
        public void ThenTheFromAccountBalanceWillBeDollars(double p0)
        {
            Assert.Equal(p0, control.cust.Accounts[0].Balance);
        }

        [Then(@"the to account will be (.*) dollars")]
        public void ThenTheToAccountWillBeDollars(double p0)
        {
            Assert.Equal(p0, control.cust.Accounts[1].Balance);
        }
    }
}
