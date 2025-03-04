Feature: Login

A short summary of the feature

Scenario: Verify that a user can login successfully
	Given that Sauce Demo application is launched
	When a user fills-in username field with standard_user
	And a user fills-in password field with secret_sauce
	And a user clicks on the login button
	And a user clicks on Sauce Labs Fleece Jacket
	And a user clicks on the add to cart button
	And a user clicks on the cart button
	Then a user should be able to see the product in the cart