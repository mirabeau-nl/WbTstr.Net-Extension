using FluentAutomation;
using NUnit.Framework;



namespace WbTstr_Net_Project_Template.Tests
{

    public class BaseTest : FluentTest
    {

        [SetUp]
        public void Init()
        {
            WbTstr.Configure()
            .PreferedBrowser().IsChrome();
            WbTstr.Bootstrap();
        }

    }
}



