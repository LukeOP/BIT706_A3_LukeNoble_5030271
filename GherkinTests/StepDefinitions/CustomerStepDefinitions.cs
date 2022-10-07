using BIT706_A3_LukeNoble_5030271;
using System;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class CustomerStepDefinitions
    {
        Controller control = new Controller();

        [Given(@"there are no customers")]
        public void GivenThereAreNoCustomers()
        {
            BankData.getInstance();
            BankData.AllCustomers.Clear();
        }

        [When(@"I add a new customer")]
        public void WhenIAddANewCustomer()
        {
            control.CreateCustomer("James", false);
        }

        [Then(@"there will be (.*) customer")]
        public void ThenThereWillBeCustomer(int p0)
        {
            Assert.Equal(p0, BankData.AllCustomers.Count);
        }
    }
}
