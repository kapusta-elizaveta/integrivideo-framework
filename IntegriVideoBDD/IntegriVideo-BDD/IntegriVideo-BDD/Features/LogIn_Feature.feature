Feature:  LogIn_Feature
	In order to access my account
    As a user of the website
   I want to log into the website

@mytag
Scenario: Successful Login with Valid Credentials
	Given User is at the LogIn Page
	And User <enter> email and <password>
	When Click on the LogIn button
	Then LogOut button should display
Examples:
| emai                        | password        |
| integriuser2@mailinator.com | integripassword | 

Scenario: Successful LogOut
    Given User is in LogIn
	When Click on the LogOut button
	Then LogIn button should display