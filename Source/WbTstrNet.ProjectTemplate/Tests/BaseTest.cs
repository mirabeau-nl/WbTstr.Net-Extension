using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

using FluentAutomation;
using NUnit.Framework;

namespace $safeprojectname$.Tests
{
    [TestFixture]
	public class BaseTest : FluentTest
	{
        [TestFixtureSetUp]
        public void TextFixtureSetUp()
        {
            WbTstr.Configure()
                .UseWebDriver(SeleniumWebDriver.Browser.PhantomJs)
                .BootstrapInstance();                 
        }
	}
}