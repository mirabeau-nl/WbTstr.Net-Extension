using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using FluentAutomation;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace $safeprojectname$.StepDefinitions.Sample
{
    [Binding]
    public class SampleFeatureSteps : BaseStepDefinition
    {
        [Given(@"I'm on the mirabeau homepage")]
        public void GivenIMOnTheMirabeauHomepage()
        {
            HomePage.Go();
        }

        [When(@"I click the language toggle")]
        public void WhenIClickTheLanguageToggle()
        {
            HomePage.ClickLanguageToggle();
        }

        [Then(@"the text of the language toggle is ""(.*)""")]
        public void ThenTheTextOfTheLanguageToggleIs(string expectedText)
        {
            string text = HomePage.GetLanguageToggleLabel();
            Assert.AreEqual(expectedText, text);
        }
    }
}
