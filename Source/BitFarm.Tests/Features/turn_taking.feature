Feature: Players take turns one after the other

Scenario: Turn ending

	Given there are two players in the game
	And it is player 1's turn
	When player 1 ends their turn
	Then it will be player 2's turn