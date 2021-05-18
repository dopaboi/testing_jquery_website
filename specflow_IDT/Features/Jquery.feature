Feature: SpinnerPage

@mytag
Scenario: Entering data into a SpinnerBox
	Given I navigate to Jquery site
	And Go to the Spinner page
	And I enter the number 12 in Input
	When Сlick on the get value button
	Then The number in the alert must equal our 12
	
	Scenario: There are Headers on the Page
	Given I navigate to Jquery site
	When I search the header 'Interactions'
	And I search the header 'Effects'
	And I search the header 'Utilities'
	And I search the header 'Widgets'
	Then The page must contain a header 'Interactions'
	And The page must contain a header 'Effects'
	And The page must contain a header 'Utilities'
	And The page must contain a header 'Widgets'

	Scenario: Does Autocomplete Work
	Given I navigate to Jquery site
	And Go to the Autocomplete Page
	And I enter the character 'a' in Autocomplete field
	When I search 'Asp' in the list
	Then In the InputField must have 'Asp'
