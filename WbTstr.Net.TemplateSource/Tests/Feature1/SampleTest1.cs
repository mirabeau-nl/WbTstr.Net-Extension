﻿using FluentAutomation;
using NUnit.Framework;


namespace WbTstr.Net_Project_Template.Tests.Feature1
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



