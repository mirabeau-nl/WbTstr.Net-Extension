using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using FluentAutomation;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : BasePage<$safeitemrootname$>
	{
        private const string Element1 = "#element1";
        private const string Element2 = "#element2";

        public $safeitemrootname$(FluentTest test) : base(test)
        {
            Url = "http://example.com";
            At = () => I.Assert.Visible(Element1);
        }

        public $safeitemrootname$ ClickOnElement2()
        {
            I.Click(Element2);

            return this;
        }
	}
}