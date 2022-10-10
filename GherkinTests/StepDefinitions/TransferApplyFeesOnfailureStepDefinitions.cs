using BIT706_A3_LukeNoble_5030271;
using System;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class TransferApplyFeesOnfailureStepDefinitions
    {
        Controller control = new Controller();
        Customer customer;
        Account account_1;
        Account account_2;
        int account_val;
        int account_val_2 = 0;

        [Given(@"the customer is ""([^""]*)""")]
        public void GivenTheCustomerIs(string state)
        {
            if (state == "staff")
            {
                customer = control.FindCustomerByName("Jane");
                control.cust = customer;
            }
            else
            {
                customer = control.FindCustomerByName("John");
                control.cust = customer;
            }
        }

        [Given(@"that they have an ""([^""]*)"" with a balance of (.*)")]
        public void GivenThatTheyHaveAnWithABalanceOf(string account, int balance)
        {
            if (account == "Everyday") { account_val = 0; account_val_2 = 1; }
            if (account == "Investment") account_val = 1;
            if (account == "Omni") account_val = 2;

            account_1 = customer.Accounts[account_val];
            account_2 = customer.Accounts[account_val_2];

            account_1.Balance = balance;

            Assert.Equal(balance, account_1.Balance);

        }

        [When(@"a transfer of (.*) fails")]
        public void WhenATransferOfFails(int amount)
        {
            control.handleTransfer(account_1, account_2, amount);
            Assert.NotNull(control.ErrorMessage);
        }

        [Then(@"the remaining balance is (.*)")]
        public void ThenTheRemainingBalanceIs(int expected)
        {
            double actual = customer.Accounts[account_val].Balance;
            Assert.Equal(expected, actual);
        }
    }
}
