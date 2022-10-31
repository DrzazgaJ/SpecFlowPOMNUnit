Feature: Find_and_click_MyAviva_Button
Find location of MyAviva button and click it

@mytag
Scenario: Open Aviva page and click on MyAviva button
	Given I am on Aviva page
	When Accept Cookies popup appears it is accepted
	When I click MyAviva button
	Then I should land on MyAviva page