Feature: AdvanceTask_Join
	With all the proper details
	Seller should be able to register into the account

@Automate1
Scenario: Seller should be able to create a new account successfully
	Given I navigate to the Mars Site
	When I Click on Join and enter all the details
	Then Seller should be able to create a new account in the Mars successfully