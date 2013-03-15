Feature: DiceRoller
	In order to play the game
	as a user
	I want to be able to roll five dice and get a scored

Background: 
Given that I have a roll scorer

######################
# Individual Die Tests
######################
Scenario: Single One
Given that I have rolled the following values
| Value |
| 1     |
When I score the roll 
Then the score should be 100

Scenario: Double ones 
Given that I have rolled the following values
| Value |
| 1     |
| 1     |
When I score the roll
Then the score should be 200

Scenario: Triple Ones 
Given that I have rolled the following values
| Value |
| 1     |
| 1     |
| 1     |
When I score the roll
Then the score should be 1000 

Scenario: Triple Twos
Given that I have rolled the following values
| Value |
| 2     |
| 2     |
| 2     |
When I score the roll 
Then the score should be 200

Scenario: Triple Threes
Given that I have rolled the following values
| Value |
| 3     |
| 3     |
| 3     |
When I score the roll 
Then the score should be 300

Scenario: Triple Fours
Given that I have rolled the following values
| Value |
| 4     |
| 4     |
| 4     |
When I score the roll 
Then the score should be 400

Scenario: Single Five
Given that I have rolled the following values
| Value |
| 5     |
When I score the roll 
Then the score should be 50

Scenario: Triple Fives
Given that I have rolled the following values
| Value |
| 5     |
| 5     |
| 5     |
When I score the roll 
Then the score should be 500

Scenario: Triple Sixes
Given that I have rolled the following values
| Value |
| 6     |
| 6     |
| 6     |
When I score the roll 
Then the score should be 600

#########################
# Examples (Integration)
#########################
Scenario: Example 1
Given that I have rolled the following values
| Value |
| 1     |
| 1     |
| 1     |
| 5     |
| 1     |
When I score the roll 
Then the score should be 1150


Scenario: Example 2
Given that I have rolled the following values
| Value |
| 2     |
| 3     |
| 4     |
| 6     |
| 2     |
When I score the roll 
Then the score should be 0


Scenario: Example 3
Given that I have rolled the following values
| Value |
| 3     |
| 4     |
| 5     |
| 3     |
| 3     |
When I score the roll 
Then the score should be 350


Scenario: Example 4
Given that I have rolled the following values
| Value |
| 1     |
| 5     |
| 1     |
| 2     |
| 4     |
When I score the roll 
Then the score should be 250


Scenario: Example 5
Given that I have rolled the following values
| Value |
| 5     |
| 5     |
| 5     |
| 5     |
| 5     |
When I score the roll 
Then the score should be 600

##################
# Extra Credit
##################
Scenario: Prevent throwing more than 6 die
Given that I have rolled the following values
| Value |
| 5     |
| 5     |
| 5     |
| 5     |
| 5     |
| 5     |
| 5     |
When I score the roll 
Then an argument exception should be thrown

## Todo: finish the rest...