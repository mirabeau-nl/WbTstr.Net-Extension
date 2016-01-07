using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using FluentAutomation;
using TechTalk.SpecFlow;

using $safeprojectname$.Pages.Common;

namespace $safeprojectname$.StepDefinitions
{
    [Binding]
    public class BaseStepDefinition : FluentTest
    {
        public BaseStepDefinition()
        {
            HomePage = new HomePage(this);

            ConfigureWbTstr();
        }

        public HomePage HomePage { get; private set; }

        private void ConfigureWbTstr()
        {
           WbTstr.Configure()
                 .UseWebDriver(SeleniumWebDriver.Browser.PhantomJs)
                 .BootstrapInstance();
        }
    }
}
