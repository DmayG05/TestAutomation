Feature: Valid Registration

In order for me to take full advantage of the website
I will need to first  be a registered as a customer
@tag1
Scenario: Valid Registration
	Given I nagivate to the website
	 And I click on Sign up
	And I Enter my Username
	And I Enter my email
	And I enter my password	
	When I click on sign up button
	Then I should be able to register succesfully
