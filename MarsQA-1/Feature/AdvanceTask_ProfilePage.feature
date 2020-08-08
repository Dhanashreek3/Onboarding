Feature: ProfilePage
	With the proper login credentials
	Seller should be able add profile details

@Automate1
Scenario: Seller should be able to add language in the profile successfully
	Given I login into Mars Portal successfully
	When I add language in the profile
	Then language that was entered should be added into the profile successfully

@Automate2
Scenario: Seller should be able to update language in the profile successfully
	Given I login into Mars Portal successfully
	When I Update language in the profile
	Then All the details in the language that was edited should be Updated into the profile

@Automate3
Scenario: Seller should be able to delete language in the profile successfully
	Given I login into Mars Portal successfully
	When I delete language in the profile
	Then All the details that was previously entered into the language should be deleted from the profile

@Automate4
Scenario: Seller should be able to add skill in the profile successfully
	Given I login into Mars Portal successfully
	When I add skill in the profile
	Then skill that was entered should be added to the profile successfully

@Automate5
Scenario: Seller should be able to update skill in the profile successfully
	Given I login into Mars Portal successfully
	When I Update skill in the profile
	Then All the details in the skill that was edited should be Updated to the profile

@Automate6
Scenario: Seller should be able to delete skill in the profile successfully
	Given I login into Mars Portal successfully
	When I delete skill in the profile
	Then All the details that was previously entered in the skill should be deleted from the profile

@Automate7
Scenario: Seller should be able to add Education in the profile successfully
	Given I login into Mars Portal successfully
	When I add Education in the profile
	Then Education that was entered should be added to the profile successfully

@Automate8
Scenario: Seller should be able to update Education in the profile successfully
	Given I login into Mars Portal successfully
	When I Update Education in the profile
	Then All the details in the Education that was edited should be Updated to the profile

@Automate9
Scenario: Seller should be able to delete Education in the profile successfully
	Given I login into Mars Portal successfully
	When I delete Education in the profile
	Then All the details that was previously entered in the Education should be deleted from the profile

@Automate10
Scenario: Seller should be able to add Certification in the profile successfully
	Given I login into Mars Portal successfully
	When I add Certification in the profile
	Then Certification that was entered should be added to the profile successfully

@Automate11
Scenario: Seller should be able to update Certification in the profile successfully
	Given I login into Mars Portal successfully
	When I Update Certification in the profile
	Then All the details in the Certification that was edited should be Updated to the profile

@Automate12
Scenario: Seller should be able to delete Certification in the profile successfully
	Given I login into Mars Portal successfully
	When I delete Certification in the profile
	Then All the details that was previously entered in the Certification should be deleted from the profile

@Automate13
Scenario: Seller should be able to add description in the description field when clicked on Save button
    Given I login into Mars Portal successfully
	When I add description in the description field
	Then Description should be added to the profile

@Automate14
Scenario: Seller should be able to search skills in the profile page successfully
    Given I login into Mars Portal successfully
	When I search in the search field
	Then user should be navigated to the search page successfully

@Automate15
Scenario: Seller should be able to change password successfully
    Given I login into Mars Portal successfully
	When I click on change password and enter all valid details
	Then password should be changed successfully

