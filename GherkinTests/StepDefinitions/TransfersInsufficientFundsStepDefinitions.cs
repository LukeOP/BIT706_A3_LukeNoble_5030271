using BIT706_A3_LukeNoble_5030271;
using System;
using System.Security.Principal;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class TransfersInsufficientFundsStepDefinitions
    {
        Account primary;
        Account secondary;
        int account_val;
        Customer customer;
        Controller control = new Controller();

        [Given(@"the primary account is ""([^""]*)""")]
        public void GivenThePrimaryAccountIs(string account)
        {
            if (account == "Everyday") account_val = 0;
            if (account == "Investment") account_val = 1;
            if (account == "Omni") account_val = 2;
            customer = control.FindCustomerByName("John");
            control.cust = customer;
            primary = customer.Accounts[account_val];
            Assert.Equal(account, primary.AccountType());
        }

        [Given(@"the secondary account is ""([^""]*)""")]
        public void GivenTheSecondaryAccountIs(string account)
        {
            if (account == "Everyday") account_val = 0;
            if (account == "Investment") account_val = 1;
            if (account == "Omni") account_val = 2;
            secondary = customer.Accounts[account_val];
            Assert.Equal(account, secondary.AccountType());
        }

        [Given(@"the initial amount of the primary account is (.*)")]
        public void GivenTheInitialAmountOfThePrimaryAccountIs(int balance)
        {
            primary.Balance = balance;
        }

        [When(@"a transfer of (.*) is made")]
        public void WhenATransferOfIsMade(int amount)
        {
            control.handleTransfer(primary, secondary, amount);
        }

        [Then(@"an error message is produced")]
        public void ThenAnErrorMessageIsProduced()
        {
            Assert.NotNull(control.ErrorMessage);
        }
    }
}
