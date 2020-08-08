Feature: AdvanceTask_LeftProfile
         With the proper login credentials
	     Seller should be able add Availability, Hours and Earn target in the profile successfully

@Automate1
Scenario: Seller should be able to add Availability in the profile successfully
	Given I login in to the Mars Portal successfully
	When I select Availability
	Then Availability that was selected should be updated to the profile successfully

@Automate2
Scenario: Seller should be able to add Hours in the profile successfully
	Given I login in to the Mars Portal successfully
	When I select Hours
	Then Hours that was selected should be updated to the profile successfully

@Automate3
Scenario: Seller should be able to add Earn target in the profile successfully
	Given I login in to the Mars Portal successfully
	When I select Earn target
	Then Earn target that was selected should be updated to the profile successfully
