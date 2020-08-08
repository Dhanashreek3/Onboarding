Feature: AdvanceTask_ShareSkill
	     With the proper login credentials
	     Seller should be able add ShareSkill in the profile successfully

@Automate1
Scenario: Seller should be able to add ShareSkill in the profile successfully
	Given I log in to the Mars Portal successfully
	When I add all the details in the Share Skill page
	Then ShareSkill details that were entered should be added to the profile successfully