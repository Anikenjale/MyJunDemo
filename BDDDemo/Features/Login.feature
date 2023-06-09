Feature: Login with Valid Credentials

 

 

Scenario: Successful Login with Valid Credentials

Given User Launch browser
Then opens URL'https://tutorialsninja.com/demo/'
When User navigate to MyAccount menu
And click on Login
And Email 'demo.aniruddhkenjale@gmail.com' and password 'demo@123'
And Click on Login button
Then User navigates to MyAccount Page