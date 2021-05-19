Feature: AutoComplete


@mytag
Scenario: Does Autocomplete Work
	Given I navigate to Jquery site
	And Go to the Autocomplete Page
	And I enter the character 'a' in Autocomplete field
	When I search 'Asp' in the list
	Then In the InputField must have 'Asp'