Feature: AutoComplete
Checking the operation of the Autocomplete page. 
You enter a symbol and check if it is possible to choose a value from the drop-down list

@mytag
Scenario: Does Autocomplete Work
	Given I navigate to Jquery site
	And Go to the Autocomplete Page
	And I enter the character 'a' in Autocomplete field
	When I search 'Asp' in the list
	Then In the InputField must have 'Asp'