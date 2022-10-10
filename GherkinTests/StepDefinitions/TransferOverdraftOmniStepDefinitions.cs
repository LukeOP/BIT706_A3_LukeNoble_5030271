using BIT706_A3_LukeNoble_5030271;
using System;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class TransferOverdraftOmniStepDefinitions
    {
        Controller control = new Controller();
        Customer customer;
        Account everyday;
        Account omni;

        [Given(@"an Omni account has a balance or (.*)")]
        public void GivenAnOmniAccountHasABalanceOr(int balance)
        {
            customer = control.cust = control.FindCustomerByName("John");
            everyday = customer.Accounts[0];
            omni = customer.Accounts[2];
            Assert.Equal("Omni", omni.AccountType());
            omni.Balance = balance;
        }

        [When(@"a transfer of (.*) is attempted")]
        public void WhenATransferOfIsAttempted(int amount)
        {
            control.handleTransfer(omni, everyday, amount);
        }

        [Then(@"the transfer will ""([^""]*)""")]
        public void ThenTheTransferWill(string expected)
        {
            string actual = "pass";
            if (control.ErrorMessage != null) actual = "fail";
            Assert.Equal(expected, actual);
        }
    }
}
