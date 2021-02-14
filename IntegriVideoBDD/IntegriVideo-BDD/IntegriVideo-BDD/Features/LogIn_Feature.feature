Feature:  LogIn_Feature
	In order to access my account
    As a user of the website
   I want to log into the website

@mytag
Scenario: Successful Login with Valid Credentials
	Given User is at the LogIn Page
	And User enter 'integriuser2@mailinator.com' username and 'integripassword' password
	When Click on the LogIn button
	Then LogOut button should display