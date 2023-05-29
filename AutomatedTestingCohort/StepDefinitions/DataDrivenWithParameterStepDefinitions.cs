using System;
using TechTalk.SpecFlow;

namespace AutomatedTestingCohort.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {
        [Given(@"i navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I enter my Username""([^""]*)""")]
        public void GivenIEnterMyUsername(string jago)
        {
            throw new PendingStepException();
        }

        [Given(@"I enter my email""([^""]*)""")]
        public void GivenIEnterMyEmail(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I enter my password""([^""]*)""")]
        public void GivenIEnterMyPassword(string jaga)
        {
            throw new PendingStepException();
        }
    }
}
