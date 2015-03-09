using FluentAutomation;
using Mirabeau.Fluent.IntegrationTests.Helpers;
using WbTstr.Net_Project_Template.Pages;

namespace WbTstr.Net_Project_Template.Pages
{
    internal class SamplePage1 : PageObject<SamplePage1>
    {
        private const string searchField = "q";
        private const string searchButton = "#gbqfsa";

        public SamplePage1(FluentTest test) : base(test)
        {
            Url = "http://www.google.com/";
            At = () => I.Assert.Visible(searchField);
        }


        public SamplePage1 Search(string searchTerm)
        {
            I.Enter(searchField).In(searchField);
            I.Click(searchButton);
            return this;
        }


    }
}