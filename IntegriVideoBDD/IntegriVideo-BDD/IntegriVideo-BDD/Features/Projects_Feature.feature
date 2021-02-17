Feature: Projects_Feature

@mytag
Scenario: Succesfull create project
	Given User is in LogIn and click add project
	And User enter <project name>, <project description> and <domain>
	When click on creare button
	Then the result should be project is created
Examples:
| project name | project description | domain   | 
| Project name | Project description | test.com | 

Scenario: Succesfull edit project page
    Given User is LogIn and open project
	And User open edit project, enter <description>
	When click update button
	Then the result should be project has description
Examples:
| description      |  
| Edit description | 

Scenario: Succesfull create component
    Given User is LogIn and open project
	And User click add icon component and enter <component name>
	When click create button
	Then the result should be component is created
Examples:
| component name   |  
| Edit description | 