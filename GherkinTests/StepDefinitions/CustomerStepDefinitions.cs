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
            if (File.Exists("../../BankData.bin")) control.ReadBinaryData();
            else
            {
                BankData.getInstance();
            }
            Assert.Equal(BankData.AllCustomers.Count(), 0);
        }

        [When(@"I add a new customer")]
        public void WhenIAddANewCustomer()
        {
            control.CreateCustomer("James", false);
        }

        [Then(@"there will be (.*) customer")]
        public void ThenThereWillBeCustomer(int p0)
        {
            Assert.Equal(BankData.AllCustomers.Count(), p0);
        }
    }
}
