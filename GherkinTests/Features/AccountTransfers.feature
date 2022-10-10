Feature: Transfers

A short summary of the feature

Background: 
Given there is an instance of BankData
And a user exists with accounts
And a staff users exists with accounts


Scenario Outline: Transfer between accounts success
Given the first account is "<AccountOne>"
And the second account is "<AccountTwo>"
And the initial amount of the from account is <InitialFrom>
When a transaction of <Amount> is made
Then the first account balance is <Result>

Examples: 
| AccountOne | AccountTwo | InitialFrom | Amount | Result |
| Everyday   | Investment | 50          | 30     | 20     |
| Everyday   | Omni       | 60          | 50     | 10     |
| Investment | Everyday   | 500         | 10     | 490    |
| Investment | Omni       | 50			| 35     | 15     |
| Omni       | Everyday   | 70			| 30     | 40     |
| Omni       | Investment | 10          | 5      | 5      |

#Scenario Outline: Transfer between accounts insufficent funds
#Given the first account is "[string]"
#And the second account is "[string]"
#And the initial amount of the from account is [int]
#When a transaction of <Amount> is made
#Then an error message is produced


#Scenario: An Error message is procuced for Failed transfer insuficient funds (Everyday).	
#	Given an Everyday account to transfer from has 10 dollars
#	And the account is not an omni account
#	When a transfer of 50 dollars is attempted
#	Then an error message is produced
#
#Scenario: An Error message is procuced for Failed transfer insuficient funds (Investment).	
#	Given an Investment account to transfer from has 10 dollars
#	And the account is an Investment account
#	When a transfer of 50 dollars is attempted
#	Then an error message is produced#Scenario: A user can make a deposit into an account
#	Given an account is selected
#	When a deposit of 10 is made
#	Then the balance has increased by 10
#
#Scenario: Successful transfer amount from one account to another
#	Given an account to transfer from has 100 dollars
#	And  and account to transfer to has 50 dollars
#	When a transfer of 30 dollars occurs
#	Then the from account balance will be 70 dollars
#	And the to account will be 80 dollars
#
#Scenario: An Error message is procuced for Failed transfer insuficient funds (Everyday).	
#	Given an Everyday account to transfer from has 10 dollars
#	And the account is not an omni account
#	When a transfer of 50 dollars is attempted
#	Then an error message is produced
#
#Scenario: An Error message is procuced for Failed transfer insuficient funds (Investment).	
#	Given an Investment account to transfer from has 10 dollars
#	And the account is an Investment account
#	When a transfer of 50 dollars is attempted
#	Then an error message is produced

#Scenario: A Fee is not charged on Everyday accounts with failed transfer	
#	Given an everyday account to transfer from has 20 dollars
#	When a transfer of 50 dollars is attempted
#	Then the everyday account will still have a balance of 20 dollars
#
#Scenario: A Fee is charged on omni accounts with failed transfer	
#	Given an omni account to transfer from has 20 dollars
#	When a transfer of 50 dollars is attempted
#	Then the omni account will only have a balance of 10 dollars
#
#Scenario: A Fee is charged on Investment accounts with failed transfer	
#	Given an investment account to transfer from has 20 dollars
#	When a transfer of 50 dollars is attempted
#	Then the omni account will only have a balance of 10 dollars
#
#Scenario: A Fee is charged on omni accounts with failed transfer (Staff)
#	Given there is a customer who is also a staff member
#	And their omni account to transfer from has 20 dollars
#	When a transfer of 500 dollars is attempted
#	Then the omni account will only have a balance of 15 dollars
#
#Scenario: A Fee is charged on Investment accounts with failed transfer (Staff)
#	Given there is a customer who is also a staff member
#	And  their investment account to transfer from has 20 dollars
#	When a transfer of 50 dollars is attempted
#	Then the omni account will only have a balance of 15 dollars
#
#Scenario: Omni account transfer into negative values (Overdraft)
#	Given an Omni account to transfer from has 10 dollars
#	When a transfer of 50 dollars is attempted
#	Then the omni account will have -40 dollars