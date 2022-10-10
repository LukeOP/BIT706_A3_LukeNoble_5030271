Feature: Transfer

Background: 
Given a user is selected

@mytag
Scenario: Transfer amounts from one account to another
Given the first account has 50
And  the second account has 100
When 20 is transfered from the first account to the second account
Then the first account should have 30
And the second account should have 120