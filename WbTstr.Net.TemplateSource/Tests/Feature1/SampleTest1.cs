using NUnit.Framework;
using FluentAutomation;
using WbTstr.Net_Project_Template.Pages;

namespace WbTstr.Net_Project_Template
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
            new SamplePage1(this)
                .Go();
        }
    }
}



