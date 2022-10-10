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



Scenario Outline: Transfer between accounts insufficent funds
Given the primary account is "<Account1>"
And the secondary account is "<Account2>"
And the initial amount of the primary account is <InitialFrom>
When a transfer of <Amount> is made
Then an error message is produced

Examples: 
| Account1   | Account2   | InitialFrom | Amount |
| Everyday   | Investment | 50          | 300    |
| Everyday   | Omni       | 60          | 500    |
| Investment | Everyday   | 500         | 800    |
| Investment | Omni       | 50          | 350    |
| Omni       | Everyday   | 70          | 300    |
| Omni       | Investment | 10          | 500    |


Scenario Outline: Transfers from Omni accounts can occur up to overdraft limit ($100)
Given an Omni account has a balance or <balance>
When a transfer of <transfer> is attempted
Then the transfer will "<result>"

Examples: 
| balance | transfer | result |
| 100     | 150      | pass   |
| 100     | 200      | pass   |
| 0       | 50       | pass   |
| -50     | 50       | pass   |
| 100     | 250      | fail   |
| 0       | 101      | fail   |
| -50     | 51       | fail   |
| -100    | 1        | fail   |

Scenario Outline: A fee is charged on appropriate accounts and staff recieve a 50% reduction in fees
Given the customer is "<state>"
And that they have an "<account_1>" with a balance of <value_1>
When a transfer of <value_2> fails
Then the remaining balance is <remaining>

Examples: 
| state     | account_1  | value_1 | value_2 | remaining |
| not_staff | Everyday   | 50      | 100     | 50        |
| not_staff | Everyday   | 0       | 100     | 0         |
| not_staff | Investment | 50      | 100     | 40        |
| not_staff | Investment | 0       | 100     | -10       |
| not_staff | Omni       | 50      | 200     | 40        |
| not_staff | Omni       | 0       | 200     | -10       |
| not_staff | Omni       | -100    | 100     | -110      |
| staff     | Everyday   | 50      | 100     | 50        |
| staff     | Everyday   | 0       | 100     | 0         |
| staff     | Investment | 50      | 100     | 45        |
| staff     | Investment | 0       | 100     | -5        |
| staff     | Omni       | 50      | 200     | 45        |
| staff     | Omni       | 0       | 200     | -5        |
| staff     | Omni       | -100    | 100     | -105      |