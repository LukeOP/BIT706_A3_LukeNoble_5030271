Feature: Customer

A short summary of the feature

@tag1
Scenario: Create a new customer
	Given there are no customers
	When I add a new customer
	Then there will be 1 customer
