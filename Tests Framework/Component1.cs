using System;

using TechTalk.SpecFlow;



namespace Tests_Framework

{

    [Binding]

    public class StepDefinitions

    {

        [Given(@"I have entered (.*) into the calculator")]

        public void GivenIHaveEnteredIntoTheCalculator(int numbers)

        {

            System.Console.WriteLine(numbers);

        }



        [When(@"I press add")]

        public void WhenIPressAdd()

        {

            System.Console.WriteLine("Pressed Add button");

        }



        [Then(@"the result should be (.*) on the screen")]

        public void ThenTheResultShouldBeOnTheScreen(int result)

        {

            if (result == 120) //Grab object of the value in the real aplication
                System.Console.WriteLine("The test PASSED");
            else
                System.Console.WriteLine("The test Failed");
        }
        }

    }

