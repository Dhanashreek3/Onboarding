Feature: AdvanceTask_ManageListing
	     With the proper login credentials
	     Seller should be able view,edit and delete skills in manage listing successfully

@Automate1
Scenario: Seller should be able to delete skill in manage listing successfully
	Given I log into the Mars Portal successfully
	When I navigate to Manage listing tab and delete the skill
	Then the skill should be deleted from manage listing successfully

@Automate2
Scenario: Seller should be able to view the skill in manage listing successfully
	Given I log into the Mars Portal successfully
	When I navigate to Manage listing tab and click on view the skill
	Then the user should be navigated to the view page successfully

@Automate3
Scenario: Seller should be able to edit the skill in manage listing successfully
	Given I log into the Mars Portal successfully
	When I navigate to Manage listing tab and click on edit the skill
	Then the user should be navigated to the edit page successfully