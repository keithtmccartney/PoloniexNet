Feature: Calculator
	I want to test the behavior of a Calculator

Scenario: Add two numbers
	Given I have a Calculator
	When I add 10 to 25
	Then the result should be 35

@Calculator 
Scenario Outline: Add two number
	Given I have a Calculator
	When I add <first> to <second>
	Then the result should be <result>
	
	Examples: 
	| first | second | result |
	| 17    | 25     | 42     |
	| 10    | 78     | 88     |
	| 2     | 25     | 27     |
	| 5     | -17    | -12    |

@Calculator
Scenario Outline: Subtract two numbers
	Given I have a Calculator
	When I subtract <first> to <second>
	Then the result should be <result>
	Examples: 
	| description | first | second | result |
	| 17_59       | 17    | 59     | -42    |
	| 10_3        | 10    | 3      | 7      |

@Calculator
Scenario Outline: Multiply two numbers
Given I have a Calculator
	When I multiply <first> to <second>
	Then the result should be <result>
	Examples: 
	| description | first | second | result |
	| 17*59       | 17    | 59     | 1003   |
	| 10*3        | 10    | 3      | 30     |

@Calculator
Scenario Outline: Divide two numbers
	Given I have a Calculator
	When I divide <first> to <second>
	Then the result should be <result>
	Examples: 
	| description | first | second | result |
	| 89/7        | 89    | 7      | 12     |
	| 106/3       | 106   | 3      | 35     |
	| 20/2        | 20    | 2      | 10     |      
