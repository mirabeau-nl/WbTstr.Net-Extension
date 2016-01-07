using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$
using FluentAutomation;

using $safeprojectname$.Pages;

namespace $safeprojectname$.Pages.Common
{
    public class HomePage : BasePage<HomePage>
    {
        private const string Navigation = "#nav";
        private const string NavContactLink = "#nav > li:nth-child(4)";

        public HomePage(FluentTest test) : base(test)
        {
            Url = "http://www.mirabeau.nl";
            At = () => I.Assert.Visible(Navigation);
        }

        public HomePage ClickNavContactLink()
        {
            I.Click(NavContactLink);

            return this;
        }
    }
}