using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shouldly;
using TechTalk.SpecFlow;
using PoloniexNet.Web;

namespace super_duper_octo_goggles.Tests.Steps
{
    [Binding]
    public class Calculator
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        /*private Program _calculator;

        [Given(@"I have a Calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Program();
        }

        [When(@"I add (.*) to (.*)")]
        public void WhenIAddTo(int first, int second)
        {
            var result = _calculator.Add(first, second);

            ScenarioContext.Current.Add("result", result);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            var actualresult = ScenarioContext.Current.Get<int>("result");

            actualresult.ShouldBe(result);
        }

        [When(@"I subtract (.*) to (.*)")]
        public void WhenISubtractTo(int first, int second)
        {
            var result = _calculator.Subtract(first, second);

            ScenarioContext.Current.Add("result", result);
        }

        [When(@"I multiply (.*) to (.*)")]
        public void WhenIMultiplyTo(int first, int second)
        {
            var result = _calculator.Multi(first, second);

            ScenarioContext.Current.Add("result", result);
        }

        [When(@"I divide (.*) to (.*)")]
        public void WhenIDivideTo(int first, int second)
        {
            var result = _calculator.Divide(first, second);

            ScenarioContext.Current.Add("result", result);
        }*/
    }
}