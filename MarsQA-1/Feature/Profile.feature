Feature: Profile
	With the proper login credentials
	Seller should be able add profile details

@Automate1
Scenario Outline: Seller should be able to add languages, skills, education, certification in the profile successfully
	Given I login in to the Mars Portal successfully
	When I add new language, skill,education,certification
	Then All the details that was entered should be added to the profile

@Automate2
Scenario: Seller should be able to update languages, skills, education, certification in the profile successfully
	Given I login in to the Mars Portal successfully
	When I Update language, (skill,education,certification)
	Then All the details that was edited should be Updated to the profile

@Automate3
Scenario: Seller should be able to delete languages, skills, education, certification in the profile successfully
	Given I login in to the Mars Portal successfully
	When I delete language, (skill,education,certification)
	Then All the details that was previously entered should be deleted from the profile
	
Scenario: Seller should be able to cancel languages, skills, education, certification in the profile successfully
	Given I login in to the Mars Portal successfully
	When I add language, skill,education,certification and click on cancel button
	Then All the details that was entered should not be added in the profile

Scenario: Seller should not be able to add duplicate data in languages, skills, education, certification in the profile
	Given I login in to the Mars Portal successfully
	When I add language, skill,education,certification that was previously added
	Then All the details that was entered should not be added to the profile

Scenario: Seller should not be able to add null data in languages, skills, education, certification in the profile
	Given I login in to the Mars Portal successfully
	When I add null values in language, skill,education,certification that was previously added
	Then Null values should not be added to the profile

Scenario: Seller should be able to add invalid data in languages, skills, education, certification in the profile successfully
	Given I login in to the Mars Portal successfully
	When I add invalid data in language, skill,education,certification
	Then All the details that was entered should not be added to the profile

Scenario: Seller should be able to add Availability, Hours, Earn Target in the profile successfully
	Given I login in to the Mars Portal successfully
	When I add new Availability, Hours, Earn Target
	Then All the details that was entered in this section should be added to the profile

Scenario: Seller should be able to update Availability, Hours, Earn Target in the profile successfully
	Given I login in to the Mars Portal successfully
	When I Update Availability, Hours, Earn Target
	Then All the details that was edited in this section should be Updated to the profile

Scenario: Seller should be able to cancel Availability, Hours, Earn Target in the profile successfully
	Given I login in to the Mars Portal successfully
	When I update Availability, Hours, Earn Target and click on cross button
	Then All the details that was edited should be cancelled from the profile

Scenario: Seller should be able to update existing data in Availability, Hours, Earn Target in the profile successfully
	Given I login in to the Mars Portal successfully
	When I Update Availability, Hours, Earn Target with the same data
	Then All the details that was edited with the same data in this section should be Updated to the profile

Scenario: Seller should not be able to update Availability, Hours, Earn Target with invalid data in the profile successfully
	Given I login in to the Mars Portal successfully
	When I Update Availability, Hours, Earn Target with the same data
	Then All the details that was edited with the same data in this section should be Updated to the profile

Scenario: Seller should be able to add Profile picture in the profile successfully
	Given I login in to the Mars Portal successfully
	When I add new profile picture
	Then Profile picture should be added to the profile

Scenario: Seller should be able to update Profile picture in the profile successfully
	Given I login in to the Mars Portal successfully
	When I update profile picture
	Then Profile picture should be updated to the profile

Scenario: Seller should be able to add description in the description field when clicked on Save button
    Given I login in to the Mars Portal successfully
	When I add description in the description field
	Then Description should be added to the profile

Scenario: Seller should be able to update description in the description field when clicked on Save button
    Given I login in to the Mars Portal successfully
	When I edit description in the description field
	Then Description should be updated to the profile

Scenario: Seller should not be able to add description for more than 600 characters
    Given I login in to the Mars Portal successfully
	When I add description in the description field for more than 600 characters
	Then Description should not be added to the profile

Scenario: Seller should not be able to add description if not clicked on Save button
    Given I login in to the Mars Portal successfully
	When I add description in the description field and do not click on Save button
	Then Description should not be added to the profile

Scenario: Seller should not be able to save if the description field is kept blank
    Given I login in to the Mars Portal successfully
	When I keep description field blank
	Then Description should not be added to the profile

Scenario: Seller should be able to save new first and last name when clicked on name
    Given I login in to the Mars Portal successfully
	When I Click on name and enter new first and last name
	Then Name should be updated successfully

Scenario: Seller should eb able to sign out when clicked on sign out button
    Given I login in to the Mars Portal successfully
	When I Click on sign out button
	Then seller should be able to come out of the profile page

Scenario: Seller should be able to see all the profile details previously entered with the language tab open
    Given I login in to the Mars Portal successfully
	When I see the profile page with language tab open
	Then seller should be able view profile with all the details that were saved previously

Scenario: Seller should be able to see name on the left side of the profile page
    Given I login in to the Mars Portal successfully
	When I see the profile page with language tab open
	Then seller should be able view name on the left side of the page

Scenario: Seller should be able to update Availability, Hours and earn target with the given data
    Given I login in to the Mars Portal successfully
	When I see the profile page with language tab open
	Then seller should be able update Availability, Hours and earn target with the given data