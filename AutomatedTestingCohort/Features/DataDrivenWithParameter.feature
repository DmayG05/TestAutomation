Feature: DataDrivenWithParameter

A short summary of the feature

@tag1
Scenario: DataDrivenParameter
	Given i navigate to "https://demo.automationtesting.in/Register.html"
	 And I click on Sign up
	And I enter my Username"Jago"
	And I enter my email"jago00@gmail.com"
	And I enter my password"jaga"	
	When I click on sign up button
	Then I should be able to register succesfully
