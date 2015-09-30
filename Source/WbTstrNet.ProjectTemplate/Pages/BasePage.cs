using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using FluentAutomation;

namespace $safeprojectname$.Pages
{
    public class BasePage<T> : PageObject<T> where T : PageObject
    {
        public BasePage(FluentTest test) : base(test)
        {
            
        } 
    }
}