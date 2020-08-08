Feature: Profile
	With the proper login credentials
	Seller should be able add profile details

@Automate1
Scenario: Seller should be able to add language in the profile successfully
	Given I login into the Mars Portal successfully
	When I add language
	Then language that was entered should be added to the profile successfully

@Automate2
Scenario: Seller should be able to update language in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update language
	Then All the details in the language that was edited should be Updated to the profile

@Automate3
Scenario: Seller should be able to delete language in the profile successfully
	Given I login into the Mars Portal successfully
	When I delete language
	Then All the details that was previously entered in the language should be deleted from the profile

Scenario: Seller should be able to cancel languages in the profile successfully
	Given I login into the Mars Portal successfully
	When I add language and click on cancel button
	Then All the details that was entered in the language should not be added in the profile

Scenario: Seller should not be able to add duplicate data in language in the profile
	Given I login into the Mars Portal successfully
	When I add language that was previously added
	Then All the details that was entered in the language section should not be added to the profile

Scenario: Seller should not be able to add null data in language in the profile
	Given I login into the Mars Portal successfully
	When I add null values in language that was previously added
	Then Null values in the language should not be added to the profile

Scenario: Seller should be able to add invalid data in language in the profile successfully
	Given I login into the Mars Portal successfully
	When I add invalid data in language
	Then All the details that was entered in the language should not be added to the profile

Scenario: Seller should be able to add skill in the profile successfully
	Given I login into the Mars Portal successfully
	When I add skill
	Then skill that was entered should be added to the profile successfully

Scenario: Seller should be able to update skill in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update skill
	Then All the details in the skill that was edited should be Updated to the profile

Scenario: Seller should be able to delete skill in the profile successfully
	Given I login into the Mars Portal successfully
	When I delete skill
	Then All the details that was previously entered in the skill should be deleted from the profile

Scenario: Seller should be able to cancel skill in the profile successfully
	Given I login into the Mars Portal successfully
	When I add skill and click on cancel button
	Then All the details that was entered in the skill should not be added in the profile

Scenario: Seller should not be able to add duplicate data in skill in the profile
	Given I login into the Mars Portal successfully
	When I add skill that was previously added
	Then All the details that was entered in the skill section should not be added to the profile

Scenario: Seller should not be able to add null data in skill in the profile
	Given I login into the Mars Portal successfully
	When I add null values in skill that was previously added
	Then Null values in the skill should not be added to the profile

Scenario: Seller should be able to add invalid data in skill in the profile successfully
	Given I login into the Mars Portal successfully
	When I add invalid data in skill
	Then All the details that was entered in the skill should not be added to the profile

Scenario: Seller should be able to add Education in the profile successfully
	Given I login into the Mars Portal successfully
	When I add Education
	Then Education that was entered should be added to the profile successfully

Scenario: Seller should be able to update Education in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update Education
	Then All the details in the Education that was edited should be Updated to the profile

Scenario: Seller should be able to delete Education in the profile successfully
	Given I login into the Mars Portal successfully
	When I delete Education
	Then All the details that was previously entered in the Education should be deleted from the profile

Scenario: Seller should be able to cancel Education in the profile successfully
	Given I login into the Mars Portal successfully
	When I add Education and click on cancel button
	Then All the details that was entered in the Education should not be added in the profile

Scenario: Seller should not be able to add duplicate data in Education in the profile
	Given I login into the Mars Portal successfully
	When I add Education that was previously added
	Then All the details that was entered in the Education section should not be added to the profile

Scenario: Seller should not be able to add null data in Education in the profile
	Given I login into the Mars Portal successfully
	When I add null values in Education that was previously added
	Then Null values in the Education should not be added to the profile

Scenario: Seller should be able to add invalid data in Education in the profile successfully
	Given I login into the Mars Portal successfully
	When I add invalid data in Education
	Then All the details that was entered in the Education should not be added to the profile

Scenario: Seller should be able to add Certification in the profile successfully
	Given I login into the Mars Portal successfully
	When I add Certification
	Then Certification that was entered should be added to the profile successfully

Scenario: Seller should be able to update Certification in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update Certification
	Then All the details in the Certification that was edited should be Updated to the profile

Scenario: Seller should be able to delete Certification in the profile successfully
	Given I login into the Mars Portal successfully
	When I delete Certification
	Then All the details that was previously entered in the Certification should be deleted from the profile

Scenario: Seller should be able to cancel Certification in the profile successfully
	Given I login into the Mars Portal successfully
	When I add Certification and click on cancel button
	Then All the details that was entered in the Certification should not be added in the profile

Scenario: Seller should not be able to add duplicate data in Certification in the profile
	Given I login into the Mars Portal successfully
	When I add Certification that was previously added
	Then All the details that was entered in the Certification section should not be added to the profile

Scenario: Seller should not be able to add null data in Certification in the profile
	Given I login into the Mars Portal successfully
	When I add null values in Certification that was previously added
	Then Null values in the Certification should not be added to the profile

Scenario: Seller should be able to add invalid data in Certification in the profile successfully
	Given I login into the Mars Portal successfully
	When I add invalid data in Certification
	Then All the details that was entered in the Certification should not be added to the profile

Scenario: Seller should be able to add Availability in the profile successfully
	Given I login into the Mars Portal successfully
	When I add new Availability
	Then All the details that was entered in availability should be added to the profile

Scenario: Seller should be able to update Availability in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update Availability
	Then All the details that was edited in availability should be Updated to the profile

Scenario: Seller should be able to cancel Availability in the profile successfully
	Given I login into the Mars Portal successfully
	When I update Availability and click on cross button
	Then All the details that was edited in availability should be cancelled from the profile

Scenario: Seller should be able to update existing data in Availability in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update Availability with the same data
	Then All the details that was edited with the same data in Availability should be Updated to the profile

	Scenario: Seller should be able to add Hours in the profile successfully
	Given I login into the Mars Portal successfully
	When I add new Hours
	Then All the details that was entered in Hours should be added to the profile

Scenario: Seller should be able to update Hours in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update Hours
	Then All the details that was edited in Hours should be Updated to the profile

Scenario: Seller should be able to cancel Hours in the profile successfully
	Given I login into the Mars Portal successfully
	When I update Hours and click on cross button
	Then All the details that was edited in Hours should be cancelled from the profile

Scenario: Seller should be able to update existing data in Hours in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update Hours with the same data
	Then All the details that was edited with the same data in Hours should be Updated to the profile

	Scenario: Seller should be able to add Earn target in the profile successfully
	Given I login into the Mars Portal successfully
	When I add new Earn target
	Then All the details that was entered in Earn target should be added to the profile

Scenario: Seller should be able to update Earn target in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update Earn target
	Then All the details that was edited in Earn target should be Updated to the profile

Scenario: Seller should be able to cancel Earn target in the profile successfully
	Given I login into the Mars Portal successfully
	When I update Earn target and click on cross button
	Then All the details that was edited in Earn target should be cancelled from the profile

Scenario: Seller should be able to update existing data in Earn target in the profile successfully
	Given I login into the Mars Portal successfully
	When I Update Earn target with the same data
	Then All the details that was edited with the same data in Earn target should be Updated to the profile

Scenario: Seller should be able to add Profile picture in the profile successfully
	Given I login into the Mars Portal successfully
	When I add new profile picture
	Then Profile picture should be added to the profile

Scenario: Seller should be able to update Profile picture in the profile successfully
	Given I login into the Mars Portal successfully
	When I update profile picture
	Then Profile picture should be updated to the profile

Scenario: Seller should be able to add description in the description field when clicked on Save button
    Given I login into the Mars Portal successfully
	When I add description in the description field
	Then Description should be added to the profile

Scenario: Seller should be able to update description in the description field when clicked on Save button
    Given I login into the Mars Portal successfully
	When I edit description in the description field
	Then Description should be updated to the profile

Scenario: Seller should not be able to add description for more than 600 characters
    Given I login into the Mars Portal successfully
	When I add description in the description field for more than 600 characters
	Then Description should not be added to the profile

Scenario: Seller should not be able to add description if not clicked on Save button
    Given I login into the Mars Portal successfully
	When I add description in the description field and do not click on Save button
	Then Description should not be added to the profile

Scenario: Seller should not be able to save if the description field is kept blank
    Given I login into the Mars Portal successfully
	When I keep description field blank
	Then Description should not be added to the profile

Scenario: Seller should be able to save new first and last name when clicked on name
    Given I login into the Mars Portal successfully
	When I Click on name and enter new first and last name
	Then Name should be updated successfully

Scenario: Seller should be able to sign out when clicked on sign out button
    Given I login into the Mars Portal successfully
	When I Click on sign out button
	Then seller should be able to come out of the profile page

Scenario: Seller should be able to see all the profile details previously entered with the language tab open
    Given I login into the Mars Portal successfully
	When I see the profile page with language tab open
	Then seller should be able view profile with all the details that were saved previously

Scenario: Seller should be able to see name on the left side of the profile page
    Given I login into the Mars Portal successfully
	When I see the profile page with language tab open
	Then seller should be able view name on the left side of the page

Scenario: Seller should be able to update Availability, Hours and earn target only with the given data
    Given I login into the Mars Portal successfully
	When I see the profile page with language tab open
	Then seller should be able update Availability, Hours and earn target only with the given data

@Automate4
Scenario: Seller should be able to add language, skill, education, certification in the profile successfully
	Given I login into the Mars Portal successfully
	When I add language, skill, education, certification
	Then language, skill, education, certification that was entered should be added to the profile successfully