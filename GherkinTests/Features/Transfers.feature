Feature: Transfers

A short summary of the feature

Background: 
Given there is an instance of BankData
And a user exists with accounts

@tag1
Scenario: A user can make a deposit into an account
	Given an account is selected
	When a deposit of 10 is made
	Then the balance has increased by 10

@tag2
Scenario: Successful transfer amount from one account to another
	Given an account to transfer from has 100 dollars
	And  and account to transfer to has 50 dollars
	When a transfer of 30 dollars occurs
	Then the from account balance will be 70 dollars
	And the to account will be 80 dollars