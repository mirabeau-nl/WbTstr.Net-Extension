using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using FluentAutomation;
using NUnit.Framework;

using $safeprojectname$.Tests;

namespace $safeprojectname$.Tests.Feature1
{
	public class Feature1Tests : BaseTest
	{
        [TestCase]
        public void UnitUnderTest_Scenario_ExpectedOutcome()
        {
            // Arrange
            // ...

            // Act 
            // ...

            // Assert
            // ...
        }
	}
}