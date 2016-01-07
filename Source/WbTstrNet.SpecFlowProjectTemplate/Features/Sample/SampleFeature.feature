Feature: SampleFeature
	A sample feature with an small example

@mytag
Scenario: Visit mirabeau.nl
	Given I'm on the mirabeau homepage  
	When I click the language toggle
	Then the text of the language toggle is "Nederlands"