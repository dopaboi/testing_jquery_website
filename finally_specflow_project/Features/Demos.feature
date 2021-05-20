Feature: Demos
Checks if the page has headers with the right text

@mytag
Scenario: There are Headers on the Page
	Given I navigate to Jquery site
	When I search the Header 
	| Header         | 
	| Interactions   |
	| Effects        |
	| Utilities      |
	| Widgets        |
	Then The Page must containt the Header
	| Header         | 
	| Interactions   |
	| Effects        |
	| Utilities      |
	| Widgets        |
	
	