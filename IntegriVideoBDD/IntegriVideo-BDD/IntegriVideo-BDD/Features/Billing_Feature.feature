Feature: Billing_Feature

@mytag
Scenario: Succesfull check wrong card
	Given User is LogIn on the page 
	And Open billing and click on add new card button
	When user enter wrong: <number card>, <month>, <year> and <name>
	Then apper message about wrong card
Examples:
| number card      | month | year | name    |
| 2343566545342222 | 12    | 2021 | integri |