﻿  Feature: SpinnerPage
  It is checked that when you entered a number in inputfield,
  the same number was in alert

@mytag
Scenario: Entering data into a SpinnerBox
	Given I navigate to Jquery site
	And Go to the Spinner page
	And I enter the number 12 in Input
	When Сlick on the get value button
	Then The number in the alert must equal our 12