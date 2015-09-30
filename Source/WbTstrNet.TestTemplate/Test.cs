using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using NUnit.Framework;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : BaseTest
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