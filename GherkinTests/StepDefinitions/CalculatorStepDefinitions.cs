namespace GherkinTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        int num1;
        int num2;
        int actual;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            num1 = number; 
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            num2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            actual = num1 + num2;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.Equal(expected, actual);
        }
    }
}