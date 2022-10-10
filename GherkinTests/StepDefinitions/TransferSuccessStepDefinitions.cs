using BIT706_A3_LukeNoble_5030271;
using System;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class TransferSuccessStepDefinitions
    {
        Controller control = new Controller();
        Customer customer;
        Account first_account;
        Account second_account;
        int account_val;

        [Given(@"the first account is ""([^""]*)""")]
        public void GivenTheFirstAccountIs(string account)
        {
            if (account == "Everyday") account_val = 0;
            if (account == "Investment") account_val = 1;
            if (account == "Omni") account_val = 2;
            customer = control.FindCustomerByName("John");
            control.cust = customer;
            first_account = customer.Accounts[account_val];
            Assert.Equal(account, first_account.AccountType());
        }

        [Given(@"the second account is ""([^""]*)""")]
        public void GivenTheSecondAccountIs(string account)
        {
            if (account == "Everyday") account_val = 0;
            if (account == "Investment") account_val = 1;
            if (account == "Omni") account_val = 2;
            second_account = customer.Accounts[account_val];
            Assert.Equal(account, second_account.AccountType());
        }

        [Given(@"the initial amount of the from account is (.*)")]
        public void GivenTheInitialAmountOfTheFromAccountIs(int balance)
        {
            first_account.Balance = balance;
        }

        [When(@"a transaction of (.*) is made")]
        public void WhenATransactionOfIsMade(int amount)
        {
            control.handleTransfer(first_account, second_account, amount);
        }

        [Then(@"the first account balance is (.*)")]
        public void ThenTheFirstAccountBalanceIs(int balance)
        {
            Assert.Equal(balance, first_account.Balance);
        }
    }
}
