using FluentAutomation;

namespace $safeprojectname$.Pages
{
    internal class SamplePage1 : PageObject<SamplePage1>
    {
        private const string ExampleField = "q";

        public SamplePage1(FluentTest test) : base(test)
        {
            Url = "http://www.google.com/";
            At = () => I.Assert.Visible(ExampleField);
        }


        public SamplePage1 Search(string searchTerm)
        {
            I.Enter(searchTerm).In(ExampleField);
            return this;
        }


    }
}