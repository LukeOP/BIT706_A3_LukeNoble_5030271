using BIT706_A3_LukeNoble_5030271;
using System;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class TransferBackgroundStepDefinitions
    {
        static Controller control = new Controller();
        public static Controller Controller { get => control; }

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
            Assert.Equal(1, BankData.AllCustomers.Count);
        }

        [Given(@"a staff users exists with accounts")]
        public void GivenAStaffUsersExistsWithAccounts()
        {
            control.CreateCustomer("Jane", true);
            Assert.Equal(2, BankData.AllCustomers.Count);
        }
    }
}
