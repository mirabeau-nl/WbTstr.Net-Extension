using FluentAutomation;
using NUnit.Framework;


namespace $safeprojectname$.Tests.Feature1
{
 
    public class SampleTests : FluentTest
    {

        [SetUp]
        public void Init()
        {
        SeleniumWebDriver.Bootstrap(
                SeleniumWebDriver.Browser.Chrome
            );
        }


        [TestCase]
        public void Test1()
        {
            
        }
    }
}



