using BIT706_A3_LukeNoble_5030271;
using System;
using TechTalk.SpecFlow;

namespace TransferTests.Specs.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        Customer customer = new Customer("James");
        Customer selectedCustomer;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"a user is selected")]
        public void GivenAUserIsSelected()
        {
            selectedCustomer = customer;
        }
    }
    [Binding]
    public class TransferStepDefinitions
    {
        [Given(@"the first account has (.*)")]
        public void GivenTheFirstAccountHas(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the second account has (.*)")]
        public void GivenTheSecondAccountHas(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"(.*) is transfered from the first account to the second account")]
        public void WhenIsTransferedFromTheFirstAccountToTheSecondAccount(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the first account should have (.*)")]
        public void ThenTheFirstAccountShouldHave(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the second account should have (.*)")]
        public void ThenTheSecondAccountShouldHave(int p0)
        {
            throw new PendingStepException();
        }
    }
}
