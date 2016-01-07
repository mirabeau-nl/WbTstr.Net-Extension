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
        private const string Header = ".main-header";
        private const string LanguageToggle = ".language-selection > li";
        private const string LanguageToggleLabel = ".language-selection > li > a";

        public HomePage(FluentTest test) : base(test)
        {
            Url = "http://www.mirabeau.nl/nl-nl";
            At = () => I.WaitUntil(() => I.Assert.Visible(Header));
        }

        public void ClickLanguageToggle()
        {
            I.Click(LanguageToggle);
        }

        public string GetLanguageToggleLabel()
        {
            I.Wait(2);
            return I.Find(LanguageToggleLabel).Element.Text;
        }
    }
}